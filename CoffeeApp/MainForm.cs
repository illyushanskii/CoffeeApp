using System;
using System.Data.SQLite;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;
using Microsoft.VisualBasic.Logging;

namespace CoffeeApp
{
    public partial class MainForm : Form
    {
        int time = 0;
        int entry = 0;
        List<Product> products = new List<Product>();
        List<Product> FiltredProducts = new List<Product>();
        public MainForm()
        {
            InitializeComponent();
            ReadProducts(products);
            UpdateForm();
            DelImages();
        }
        public MainForm(string adm)
        {
            InitializeComponent();
            this.Visible = false;
            AdminForm admin = new AdminForm(this);
            admin.ShowDialog();
            products = admin.GetProducts();
        }
        public List<Product> GetList()
        {
            return products;
        }
        private void toolStripComboBox1_Click(object sender, EventArgs e)
        {

        }

        public void ReadProducts(List<Product>read)
        {
            read.Clear();
            DataBase data = new DataBase();
            data.openBase();

            SQLiteCommand cmd = new SQLiteCommand("SELECT * FROM Products", data.getConnection());
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
            data.closeBase();
        }
        public void UpdateForm()
        {
            
            FiltredProducts = new List<Product>(products);
            panel1.Controls.Clear();
            int y = 30;
            if (FiltredProducts.Count == 0)
            {
                Label noSearch = new Label();
                noSearch.Text = "За даними параметрами пошуку нічого не знайдено!";
                noSearch.Location = new Point(15, 30);
                Font font = new Font("Arial", 19, FontStyle.Bold);
                noSearch.Font = font;
                noSearch.AutoSize = true;
                panel1.Controls.Add(noSearch);
                return;
            }
            for (int inx = 0; inx < FiltredProducts.Count; inx++)
            {
                Product product = FiltredProducts[inx];
                PictureBox pictureBox = new PictureBox();
                System.Windows.Forms.TextBox textBoxInfo = new System.Windows.Forms.TextBox();
                NumericUpDown numericUpDownQuantity = new NumericUpDown();
                Label labelQuantity = new Label();
                System.Windows.Forms.Button delButton = new System.Windows.Forms.Button();
                System.Windows.Forms.Button editButton = new System.Windows.Forms.Button();

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

                Font quantityFont = new Font("Arial", 12);
                numericUpDownQuantity.Font = quantityFont;
                numericUpDownQuantity.Location = new Point(630, y + 50);
                numericUpDownQuantity.Width = 100;
                numericUpDownQuantity.Tag = inx;
                numericUpDownQuantity.Minimum = 0;
                numericUpDownQuantity.Maximum = 9999999999;
                numericUpDownQuantity.Value = product.Quantity();
                numericUpDownQuantity.MouseWheel += NumericUpDownQuantity_MouseWheel;
                //numericUpDownQuantity.ValueChanged += NumericUpDownQuantity_ValueChanged;


                labelQuantity.Font = quantityFont;
                labelQuantity.Text = "Кількість";
                labelQuantity.Location = new Point(630, y + 20);
                labelQuantity.AutoSize = true;

                Font buttonFont = new Font("Arial", 10, FontStyle.Bold);
                delButton.Font = buttonFont;
                delButton.Location = new Point(740, y + 5);
                delButton.Tag = inx;
                //delButton.Click += DelButton_Click;
                delButton.Width = 110;
                delButton.BackColor = Color.Red;
                delButton.Height = 45;
                delButton.Text = "Видалити";

                editButton.Font = buttonFont;
                editButton.Location = new Point(740, y + 55);
                editButton.Tag = inx;
                //editButton.Click += EditButton_Click;
                editButton.Width = 110;
                editButton.BackColor = Color.Yellow;
                editButton.Height = 45;
                editButton.Text = "Змінити";

                panel1.Controls.Add(pictureBox);
                panel1.Controls.Add(textBoxInfo);
                panel1.Controls.Add(delButton);
                panel1.Controls.Add(editButton);
                panel1.Controls.Add(numericUpDownQuantity);
                panel1.Controls.Add(labelQuantity);
                y += 110;
            }
        }

        private void NumericUpDownQuantity_MouseWheel(object sender, MouseEventArgs e)
        {
            ((HandledMouseEventArgs)e).Handled = true;
        }
        private void TextBoxSearch_Click(object sender, EventArgs e)
        {

        }

        private void LabelAdmin_MouseDown(object sender, MouseEventArgs e)
        {
            time = 0;
            timer1.Start();
        }


        private void LabelAdmin_MouseUp(object sender, MouseEventArgs e)
        {
            timer1.Stop();
            if (time >= 5 && entry == 0)
            {
                LoginForm login = new LoginForm();
                login.ShowDialog();
                if (login.DialogResult == DialogResult.OK)
                {
                    this.Visible = false;
                    AdminForm admin = new AdminForm(this, new List<Product>(products));
                    admin.ShowDialog();
                    products = admin.GetProducts();
                  
                }
                else if (login.DialogResult == DialogResult.No)
                {
                    MessageBox.Show("No");
                    timer2.Start();
                }
            }
            else if(time >= 5)
            {
                MessageBox.Show(entry.ToString());
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            time += 1;
        }

        private void ButtonFilter_Click(object sender, EventArgs e)
        {
        }

        private void ButtonSort_ButtonClick(object sender, EventArgs e)
        {

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (entry == 60)
            {
                timer2.Stop();
                entry = 0;
                return;
            }
            else
            {
                entry++;
            }
        }
        private void DelImages()
        {
            string path = ".\\\\ProductsImage";
            if (Directory.Exists(path))
            {
                string[] files = Directory.GetFiles(path);

                List<string> temp = new List<string>();
                DataBase data = new DataBase();
                data.openBase();
                SQLiteCommand cmd = new SQLiteCommand("SELECT `Image` FROM `Products`", data.getConnection());
                using (SQLiteDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        temp.Add(reader.GetString(reader.GetOrdinal("Image")));
                    }
                }
                data.closeBase();
                string[] dataImages = temp.ToArray();

                foreach (string file in files)
                {
                    if (!dataImages.Contains(file) && file != ".\\Icons\\image.png")
                    {
                        try
                        {
                            File.Delete(file);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"Помилка видалення файла {file}: {ex.Message}");
                        }
                    }
                }
            }
        }
    }
}
