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
            // Очищуємо панель перед додаванням нових елементів
            panel1.Controls.Clear();
            int y = 10; // Початкова позиція для вертикального розташування
            double allPrice = 0;

            // Відображення повідомлення, якщо кошик порожній
            if (carts.Count == 0)
            {
                ShowEmptyCartMessage();
                return;
            }

            // Додаємо товари з кошика
            foreach (var (cart, index) in carts.Select((cart, index) => (cart, index)))
            {
                allPrice += cart.PriceSell() * cart.Quantity();

                // Додаємо картинку товару
                PictureBox pictureBox = CreatePictureBox(cart.ImagePath(), new Point(10, y));

                // Інформація про товар
                TextBox textBoxInfo = CreateTextBox(cart.Description(), new Point(120, y + 5));

                // Лічильник кількості товару
                NumericUpDown numericUpDownQuantity = CreateNumericUpDown(cart.Quantity(), cart.ProductQuantity(), index, new Point(630, y + 35));

                // Лейбли для кількості та ціни
                Label labelQuantity = CreateLabel("Кількість", new Point(630, y + 5));
                Label labelPrice = CreateLabel($"Ціна {cart.PriceSell():F2} грн.", new Point(630, y + 75), Color.Red);

                // Кнопка видалення товару
                Button delButton = CreateDeleteButton(index, new Point(740, y + 30));

                // Додаємо всі елементи до панелі
                panel1.Controls.AddRange(new Control[] { pictureBox, textBoxInfo, numericUpDownQuantity, labelQuantity, labelPrice, delButton });

                y += 110; // Зсув для наступного товару
            }

            // Оновлюємо загальну суму
            labelAllPrice.Text = allPrice.ToString("F2");
        }

        private void ShowEmptyCartMessage()
        {
            panel1.Controls.Clear();

            // Встановлення зображення
            PictureBox pictureBox = new PictureBox
            {
                Image = Image.FromFile(".\\Icons\\EmptyCart.png"),
                SizeMode = PictureBoxSizeMode.Zoom,
                Size = new Size(panel1.Width / 3, panel1.Width / 3), // Розмір залежить від ширини панелі
                Location = new Point(panel1.Width / 2 - (panel1.Width / 6), 10) // Центр зображення
            };

            // Повідомлення
            Label message = new Label
            {
                Text = "Нажаль кошик порожній, поповніть його :)",
                Font = new Font("Segoe UI", 14, FontStyle.Bold),
                ForeColor = Color.FromArgb(82, 38, 7),
                AutoSize = true,
                Location = new Point(panel1.Width / 2 - 200, pictureBox.Bottom + 10)
            };

            // Кнопка
            Button button = new Button
            {
                Text = "За покупками",
                AutoSize = true,
                BackColor = Color.Tan,
                ForeColor = Color.FromArgb(82, 38, 7),
                Font = new Font("Segoe UI", 12, FontStyle.Regular),
                FlatStyle = FlatStyle.Flat,
                Location = new Point(panel1.Width / 2 - 75, message.Bottom + 20)
            };

            groupBox1.Visible = false;

            // Додаємо елементи на панель
            panel1.Controls.AddRange(new Control[] { pictureBox, message, button });

            // Адаптивність при зміні розмірів
            this.Resize += (s, e) => ShowEmptyCartMessage();
        }


        private PictureBox CreatePictureBox(string imagePath, Point location)
        {
            return new PictureBox
            {
                Image = Image.FromFile(imagePath),
                SizeMode = PictureBoxSizeMode.StretchImage,
                Location = location,
                Size = new Size(100, 100)
            };
        }

        private TextBox CreateTextBox(string text, Point location)
        {
            return new TextBox
            {
                Text = text,
                Font = new Font("Arial", 15),
                Location = location,
                ReadOnly = true,
                Multiline = true,
                Width = 500,
                Height = 100
            };
        }

        private NumericUpDown CreateNumericUpDown(int currentQuantity, int maxQuantity, int tag, Point location)
        {
            NumericUpDown numericUpDown = new NumericUpDown
            {
                Font = new Font("Arial", 12),
                Location = location,
                Width = 100,
                Minimum = 1,
                Maximum = maxQuantity,
                Value = currentQuantity,
                Tag = tag
            };
            numericUpDown.ValueChanged += NumericUpDownQuantity_ValueChanged;
            return numericUpDown;
        }

        private Label CreateLabel(string text, Point location, Color? foreColor = null)
        {
            return new Label
            {
                Text = text,
                Font = new Font("Arial", 12),
                Location = location,
                AutoSize = true,
                ForeColor = foreColor ?? Color.Black
            };
        }

        private Button CreateDeleteButton(int tag, Point location)
        {
            Button button = new Button
            {
                Font = new Font("Arial", 10, FontStyle.Bold),
                Location = location,
                Tag = tag,
                Size = new Size(50, 50),
                BackColor = Color.Red,
                Image = new Bitmap(".\\Icons\\trash.png"),
                Text = ""
            };
            button.Click += DelButton_Click;
            return button;
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
