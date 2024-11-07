using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace CoffeeApp
{
    public partial class DeletedForm : Form
    {
        List<Product> products = new List<Product>();
        List<Product> productsIn = new List<Product>();
        public DeletedForm(List<Product> ProductsIn)
        {
            InitializeComponent();
            this.productsIn = ProductsIn;
            ReadProducts(products);
            UpdateForm();
        }
        private void UpdateForm()
        {
            panel1.Controls.Clear();
            int y = 5;
            if (products.Count == 0)
            {
                Label noSearch = new Label();
                noSearch.Text = "Видалених товарів немає!";
                noSearch.Location = new Point(160,50);
                Font font = new Font("Arial", 19, FontStyle.Bold);
                noSearch.Font = font;
                noSearch.AutoSize = true;
                panel1.Controls.Add(noSearch);
                return;
            }
            for (int inx = 0; inx < products.Count; inx++)
            {
                Product product = products[inx];
                PictureBox pictureBox = new PictureBox();
                System.Windows.Forms.TextBox textBoxInfo = new System.Windows.Forms.TextBox();
                System.Windows.Forms.Button returnButton = new System.Windows.Forms.Button();
                System.Windows.Forms.Button infoButton = new System.Windows.Forms.Button();

                pictureBox.Image = System.Drawing.Image.FromFile(product.ImagePath());
                pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBox.Location = new Point(10, y);
                pictureBox.Size = new Size(100, 100);

                Font textFont = new Font("Arial", 15);
                textBoxInfo.Text = product.ToString();
                textBoxInfo.Font = textFont;
                textBoxInfo.Location = new Point(120, y + 5);
                textBoxInfo.ReadOnly = true;
                textBoxInfo.Multiline = true;
                textBoxInfo.Width = 500;
                textBoxInfo.Height = 100;
                textBoxInfo.MouseWheel += TextBoxInfo_MouseWheel;

                Font buttonFont = new Font("Arial", 10, FontStyle.Bold);
                returnButton.Font = buttonFont;
                returnButton.Location = new Point(630, y + 10);
                returnButton.Tag = inx;
                returnButton.Click += ReturnButton_Click;
                returnButton.Width = 150;
                returnButton.BackColor = Color.FromArgb(0, 241, 43);
                returnButton.Height = 45;
                returnButton.Image = Image.FromFile(".\\Icons\\return.png");
                returnButton.ImageAlign = ContentAlignment.MiddleLeft;
                returnButton.ForeColor = Color.White;
                returnButton.Text = "     Повернути";

                infoButton.Font = buttonFont;
                infoButton.Location = new Point(630, y + 55);
                infoButton.Tag = inx;
                infoButton.Click += InfoButton_Click;
                infoButton.Width = 150;
                infoButton.BackColor = Color.DeepSkyBlue;
                infoButton.Height = 45;
                infoButton.Text = "Характеристики";

                panel1.Controls.Add(pictureBox);
                panel1.Controls.Add(textBoxInfo);
                panel1.Controls.Add(returnButton);
                panel1.Controls.Add(infoButton);
                y += 110;
            }
        }

        private void ReturnButton_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Button clickedButton = (System.Windows.Forms.Button)sender;
            int inx = (int)clickedButton.Tag;

            DataBase data = new DataBase();
            data.openBase();

            using (SQLiteCommand cmd = new SQLiteCommand("INSERT INTO `Products` (`ID`, `Name`,`Popularity`,`Description`,`PriceBuy`,`PriceSell`,`Quantity`,`Weight`,`Type`,`MadeIn`,`Composition`,`Image`) SELECT `ID`, `Name`,`Popularity`,`Description`,`PriceBuy`,`PriceSell`,`Quantity`,`Weight`,`Type`,`MadeIn`,`Composition`,`Image` FROM `DeletedProducts` WHERE id = @id;", data.getConnection()))
            {
                cmd.Parameters.Add("@id", DbType.Int32).Value = products[inx].ID();
                cmd.ExecuteNonQuery();
            }

            using (SQLiteCommand cmd = new SQLiteCommand("DELETE FROM DeletedProducts WHERE ID = @id;", data.getConnection()))
            {
                cmd.Parameters.Add("@id", DbType.Int32).Value = products[inx].ID();
                cmd.ExecuteNonQuery();
    
            }
            data.closeBase();
            productsIn.Add(products[inx]);
            products.RemoveAt(inx);
            UpdateForm();
        }

        private void InfoButton_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Button clickedButton = (System.Windows.Forms.Button)sender;
            int inx = (int)clickedButton.Tag;
            InfoForm infoForm = new InfoForm(products[inx]);
            infoForm.ShowDialog(this);
        }
        private void TextBoxInfo_MouseWheel(object sender, MouseEventArgs e)
        {
            int position = panel1.VerticalScroll.Value - e.Delta;

            position = Math.Max(0, Math.Min(position, panel1.VerticalScroll.Maximum));
            panel1.VerticalScroll.Value = position;
            panel1.PerformLayout();
        }
        private void ReadProducts(List<Product> read)
        {
            read.Clear();
            DataBase data = new DataBase();
            data.openBase();

            using (SQLiteCommand cmd = new SQLiteCommand("SELECT * FROM DeletedProducts", data.getConnection()))
            {
                using (SQLiteDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Product newProd = new Product();
                        newProd.ID(reader.GetInt32(reader.GetOrdinal("ID")));
                        newProd.Name(reader.GetString(reader.GetOrdinal("Name")));
                        newProd.Popularity(reader.GetInt32(reader.GetOrdinal("Popularity")));
                        newProd.Description(reader.GetString(reader.GetOrdinal("Description")));
                        newProd.PriceBuy(reader.GetDouble(reader.GetOrdinal("PriceBuy")));
                        newProd.PriceSell(reader.GetDouble(reader.GetOrdinal("PriceSell")));
                        newProd.Quantity(reader.GetInt32(reader.GetOrdinal("Quantity")));
                        newProd.Weight(reader.GetDouble(reader.GetOrdinal("Weight")));
                        newProd.Type(reader.GetString(reader.GetOrdinal("Type")));
                        newProd.MadeIn(reader.GetString(reader.GetOrdinal("MadeIn")));
                        newProd.Composition(reader.GetString(reader.GetOrdinal("Composition")));
                        newProd.ImagePath(reader.GetString(reader.GetOrdinal("Image")));
                        read.Add(newProd);
                    }
                }
            }
            data.closeBase();
        }
    }
}
