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

namespace CoffeeApp
{
    public partial class CasaForm : Form
    {
        List<Cart>carts = new List<Cart>();
        public CasaForm()
        {
            InitializeComponent();
            ReadCarts(carts);
            UpdateForm();
        }
        private void ReadCarts(List<Cart> read)
        {
            read.Clear();
            DataBase data = new DataBase();
            data.openBase();

            using (SQLiteCommand cmd = new SQLiteCommand("SELECT * FROM Carts", data.getConnection()))
            {
                using (SQLiteDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Cart newCart = new Cart();
                        newCart.ProductId(reader.GetInt32(reader.GetOrdinal("ProductId")));
                        newCart.Description(reader.GetString(reader.GetOrdinal("Description")));
                        newCart.PriceBuy(reader.GetDouble(reader.GetOrdinal("PriceBuy")));
                        newCart.PriceSell(reader.GetDouble(reader.GetOrdinal("PriceSell")));
                        newCart.Quantity(reader.GetInt32(reader.GetOrdinal("Quantity")));
                        newCart.ProductQuantity(0);
                        newCart.Popularity(0);
                        newCart.ImagePath(reader.GetString(reader.GetOrdinal("Image")));
                        read.Add(newCart);
                    }
                }
            }
            data.closeBase();
        }
        private void UpdateForm()
        {
            panel1.Controls.Clear();
            int y = 10;
            double totalCosts = 0;
            double totalCasa = 0;
            if (carts.Count == 0)
            {
                PictureBox pictureBox = new PictureBox();
                pictureBox.Image = System.Drawing.Image.FromFile(".\\Icons\\emptyCasa.png");
                pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
                pictureBox.Location = new Point(320, 50);
                pictureBox.Size = new Size(250, 250);

                Label message = new Label();
                message.Text = "Нажаль каса порожня!";
                message.Location = new Point(320, 310);
                message.AutoSize = true;
                message.Font = new Font("Segoe UI", 14, FontStyle.Bold);
                message.ForeColor = Color.FromArgb(82, 38, 7);

                Button button = new Button();
                button.Text = "Закрити";
                button.AutoSize = true;
                button.Location = new Point(405, 350);
                button.Font = new Font("Segoe UI", 12, FontStyle.Regular);
                button.BackColor = Color.Tan;
                button.ForeColor = Color.FromArgb(82, 38, 7);
                button.FlatStyle = FlatStyle.Flat;
                button.FlatAppearance.BorderSize = 1;
                button.FlatAppearance.BorderColor = Color.FromArgb(82, 38, 7); 
                button.Cursor = Cursors.Hand; 
                button.DialogResult = DialogResult.Cancel;

                panel1.Dock = DockStyle.Fill;
                this.Height -= 80;
                groupBox1.Visible = false;
                panel1.Controls.Add(pictureBox);
                panel1.Controls.Add(message);
                panel1.Controls.Add(button);
                return;
            }
            for (int inx = 0; inx < carts.Count; inx++)
            {
                Cart product = carts[inx];
                PictureBox pictureBox = new PictureBox();
                System.Windows.Forms.TextBox textBoxInfo = new System.Windows.Forms.TextBox();
                NumericUpDown numericUpDownQuantity = new NumericUpDown();
                Label labelQuantity = new Label();
                Label labelPriceSell = new Label();
                Label labelPriceBuy = new Label();
                System.Windows.Forms.Button delButton = new System.Windows.Forms.Button();

                pictureBox.Image = System.Drawing.Image.FromFile(product.ImagePath());
                pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBox.Location = new Point(10, y);
                pictureBox.Size = new Size(100, 100);

                Font textFont = new Font("Arial", 15);
                textBoxInfo.Text = $"{product.ProductId().ToString()}){product.Description()}";
                textBoxInfo.Font = textFont;
                textBoxInfo.Location = new Point(120, y + 5);
                textBoxInfo.ReadOnly = true;
                textBoxInfo.Multiline = true;
                textBoxInfo.MouseWheel += TextBoxInfo_MouseWheel;
                textBoxInfo.Width = 500;
                textBoxInfo.Height = 100;

                Font quantityFont = new Font("Arial", 12);
                labelQuantity.Font = quantityFont;
                labelQuantity.Text = $"Продано: {product.Quantity().ToString()} шт.";
                labelQuantity.Location = new Point(630, y + 15);
                labelQuantity.AutoSize = true;

                labelPriceSell.Font = quantityFont;
                labelPriceSell.Text = $"Зароблено: {product.PriceSell().ToString("F2")} грн.";
                labelPriceSell.Location = new Point(630, y + 45);
                labelPriceSell.AutoSize = true;
                labelPriceSell.ForeColor = Color.Blue;

                labelPriceBuy.Font = quantityFont;
                labelPriceBuy.Text = $"Витрачено: {product.PriceBuy().ToString("F2")} грн.";
                labelPriceBuy.Location = new Point(630, y + 75);
                labelPriceBuy.AutoSize = true;
                labelPriceBuy.ForeColor = Color.Red;

                panel1.Controls.Add(pictureBox);
                panel1.Controls.Add(textBoxInfo);
                panel1.Controls.Add(labelPriceSell);
                panel1.Controls.Add(labelQuantity);
                panel1.Controls.Add(labelPriceBuy);
                totalCosts += product.PriceBuy();
                totalCasa += product.PriceSell();
                y += 110;
            }
            labelCasa.Text = $"Каса загалом: {totalCasa} грн.";
            labelCosts.Text = $"Витрати на  товари: {totalCosts} грн.";
            labelIncome.Text = $"Дохід: {(totalCasa-totalCosts)} грн.";
        }

        private void TextBoxInfo_MouseWheel(object sender, MouseEventArgs e)
        {
            int position = panel1.VerticalScroll.Value - e.Delta;

            position = Math.Max(0, Math.Min(position, panel1.VerticalScroll.Maximum));
            panel1.VerticalScroll.Value = position;
            panel1.PerformLayout();
        }
    }
}
