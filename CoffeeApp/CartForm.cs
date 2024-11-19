using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Data.Entity.Infrastructure.Design.Executor;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace CoffeeApp
{
    public partial class CartForm : Form
    {
        List<Cart> carts = new List<Cart>();
        MainForm mainForm;
        public CartForm(List<Cart> CartsIn, MainForm form)
        {
            InitializeComponent();
            carts = CartsIn;
            mainForm = form;
            UpdateForm();
        }

        private void UpdateForm()
        {
            panel1.Controls.Clear();
            int y = 10;
            double allPrice = 0;
            if (carts.Count == 0)
            {
                PictureBox pictureBox = new PictureBox();
                pictureBox.Image = System.Drawing.Image.FromFile(".\\Icons\\EmptyCart.png");
                pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
                pictureBox.Location = new Point(274, y);
                pictureBox.Size = new Size(250, 250);

                Label message = new Label();
                message.Text = "Нажаль кошик порожній, поповніть його :)";
                message.Location = new Point(260, 280);
                message.AutoSize = true;
                message.Font = new Font("Segoe UI", 14, FontStyle.Bold);
                message.ForeColor = Color.FromArgb(82, 38, 7);

                Button button = new Button();
                button.Text = "За покупками";
                button.AutoSize = true;
                button.Location = new Point(365, 320);
                button.BackColor = Color.Tan;
                button.ForeColor = Color.FromArgb(82, 38, 7);
                button.Font = new Font("Segoe UI", 12, FontStyle.Regular);
                button.FlatStyle = FlatStyle.Flat;
                button.FlatAppearance.BorderSize = 1;
                button.FlatAppearance.BorderColor = Color.FromArgb(82, 38, 7);
                button.Cursor = Cursors.Hand;
                button.DialogResult = DialogResult.Cancel;

                this.Height -= 60;
                groupBox1.Visible = false;
                panel1.Controls.Add(pictureBox);
                panel1.Controls.Add(message);
                panel1.Controls.Add(button);
            }
            for (int inx = 0; inx < carts.Count; inx++)
            {
                allPrice += (carts[inx].PriceSell() * carts[inx].Quantity());
                mainForm.ButtonCart.Checked = true;
                Cart product = carts[inx];
                PictureBox pictureBox = new PictureBox();
                System.Windows.Forms.TextBox textBoxInfo = new System.Windows.Forms.TextBox();
                NumericUpDown numericUpDownQuantity = new NumericUpDown();
                Label labelQuantity = new Label();
                Label labelPrice = new Label();
                System.Windows.Forms.Button delButton = new System.Windows.Forms.Button();

                pictureBox.Image = System.Drawing.Image.FromFile(product.ImagePath());
                pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBox.Location = new Point(10, y);
                pictureBox.Size = new Size(100, 100);

                Font textFont = new Font("Arial", 15);
                textBoxInfo.Text = $"{product.Description()}";
                textBoxInfo.Font = textFont;
                textBoxInfo.Location = new Point(120, y + 5);
                textBoxInfo.ReadOnly = true;
                textBoxInfo.Multiline = true;
                textBoxInfo.Width = 500;
                textBoxInfo.Height = 100;

                Font quantityFont = new Font("Arial", 12);
                numericUpDownQuantity.Font = quantityFont;
                numericUpDownQuantity.Location = new Point(630, y + 35);
                numericUpDownQuantity.Width = 100;
                numericUpDownQuantity.Tag = inx;
                numericUpDownQuantity.Minimum = 1;
                numericUpDownQuantity.Maximum = product.ProductQuantity();
                numericUpDownQuantity.Value = product.Quantity();
                numericUpDownQuantity.ValueChanged += NumericUpDownQuantity_ValueChanged;


                labelQuantity.Font = quantityFont;
                labelQuantity.Text = "Кількість";
                labelQuantity.Location = new Point(630, y + 5);
                labelQuantity.AutoSize = true;

                labelPrice.Font = quantityFont;
                labelPrice.Text = $"Ціна {product.PriceSell().ToString("F2")} грн.";
                labelPrice.Location = new Point(630, y + 75);
                labelPrice.AutoSize = true;
                labelPrice.ForeColor = Color.Red;

                Font buttonFont = new Font("Arial", 10, FontStyle.Bold);
                delButton.Font = buttonFont;
                delButton.Location = new Point(740, y + 30);
                delButton.Tag = inx;
                delButton.Click += DelButton_Click;
                delButton.Size = new Size(50, 50);
                delButton.BackColor = Color.Red;
                delButton.Image = new Bitmap(".\\Icons\\trash.png");
                delButton.Text = "";

                panel1.Controls.Add(pictureBox);
                panel1.Controls.Add(textBoxInfo);
                panel1.Controls.Add(delButton);
                panel1.Controls.Add(numericUpDownQuantity);
                panel1.Controls.Add(labelQuantity);
                panel1.Controls.Add(labelPrice);
                y += 110;
            }
            labelAllPrice.Text = allPrice.ToString("F2");
        }

        private void DelButton_Click(object? sender, EventArgs e)
        {
            System.Windows.Forms.Button clickedButton = (System.Windows.Forms.Button)sender;
            int inx = (int)clickedButton.Tag;
            carts.Remove(carts[inx]);
            UpdateForm();
        }

        private void NumericUpDownQuantity_ValueChanged(object sender, EventArgs e)
        {
            NumericUpDown numeric = (NumericUpDown)sender;
            int inx = (int)numeric.Tag;
            carts[inx].Quantity((int)numeric.Value);
            UpdateForm();
        }

        private void buttonPay_Click(object sender, EventArgs e)
        {
            if (carts.Count != 0)
            {
                DataBase db = new DataBase();
                db.openBase();

                foreach (Cart cart in carts)
                {
                    using (SQLiteCommand cmd = new SQLiteCommand("UPDATE Products SET Quantity = @quantity, Popularity = @popularity WHERE ID = @id", db.getConnection()))
                    {
                        cmd.Parameters.Add("@id", DbType.Int32).Value = cart.ProductId();
                        cmd.Parameters.Add("@quantity", DbType.Int32).Value = (cart.ProductQuantity() - cart.Quantity());
                        cmd.Parameters.Add("@popularity", DbType.Int32).Value = (cart.Popularity() + 1);
                        cmd.ExecuteNonQuery();
                    }
                }

                foreach (Cart cart in carts)
                {
                    using (SQLiteCommand cmd1 = new SQLiteCommand("SELECT EXISTS(SELECT 1 FROM Carts WHERE ProductId = @id)", db.getConnection()))
                    {
                        cmd1.Parameters.Add("@id", DbType.Int32).Value = cart.ProductId();
                        int exists = Convert.ToInt32(cmd1.ExecuteScalar());

                        if (exists != 1)
                        {
                            using (SQLiteCommand cmd2 = new SQLiteCommand("INSERT INTO Carts (ProductId, Description, PriceBuy, PriceSell, Quantity, Image) VALUES (@id, @description, @priceBuy, @priceSell, @quantity, @image)", db.getConnection()))
                            {
                                cmd2.Parameters.Add("@id", DbType.Int32).Value = cart.ProductId();
                                cmd2.Parameters.Add("@description", DbType.String).Value = cart.Description();
                                cmd2.Parameters.Add("@priceBuy", DbType.Double).Value = (cart.Quantity() * cart.PriceBuy());
                                cmd2.Parameters.Add("@priceSell", DbType.Double).Value = (cart.Quantity() * cart.PriceSell());
                                cmd2.Parameters.Add("@quantity", DbType.Int32).Value = cart.Quantity();
                                cmd2.Parameters.Add("@image", DbType.String).Value = cart.ImagePath();
                                cmd2.ExecuteNonQuery();
                            }
                        }
                        else
                        {
                            int allQuantity = 0;
                            double allBuy = 0;
                            double allSell = 0;

                            using (SQLiteCommand cmd3 = new SQLiteCommand("SELECT * FROM Carts WHERE ProductId = @id", db.getConnection()))
                            {
                                cmd3.Parameters.Add("@id", DbType.Int32).Value = cart.ProductId();
                                using (SQLiteDataReader reader = cmd3.ExecuteReader())
                                {
                                    if (reader.Read())
                                    {
                                        allBuy = reader.GetDouble(reader.GetOrdinal("PriceBuy"));
                                        allSell = reader.GetDouble(reader.GetOrdinal("PriceSell"));
                                        allQuantity = reader.GetInt32(reader.GetOrdinal("Quantity"));
                                    }
                                }
                            }

                            allQuantity += cart.Quantity();
                            allBuy += (cart.Quantity() * cart.PriceBuy());
                            allSell += (cart.Quantity() * cart.PriceSell());

                            using (SQLiteCommand cmd4 = new SQLiteCommand("UPDATE Carts SET Quantity = @quantity, PriceBuy = @priceBuy, PriceSell = @priceSell WHERE ProductId = @id", db.getConnection()))
                            {
                                cmd4.Parameters.Add("@id", DbType.Int32).Value = cart.ProductId();
                                cmd4.Parameters.Add("@priceBuy", DbType.Double).Value = allBuy;
                                cmd4.Parameters.Add("@priceSell", DbType.Double).Value = allSell;
                                cmd4.Parameters.Add("@quantity", DbType.Int32).Value = allQuantity;
                                cmd4.ExecuteNonQuery();
                            }
                        }
                    }
                }

                db.closeBase();
                carts.Clear();
                mainForm.ButtonCart.Checked = false;
                MessageBox.Show("Дякуємо за покупку!");
                this.DialogResult = DialogResult.OK;
            }
        }

    }
}
