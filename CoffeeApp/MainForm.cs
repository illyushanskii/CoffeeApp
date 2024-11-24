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
        List<Cart> carts = new List<Cart>();
        Filter filterProd;
        string sortProd = "pop";
        public MainForm()
        {
            InitializeComponent();
            ReadProducts(products);
            FiltredProducts = new List<Product>(products);
            UpdateForm();
            DelImages();
            
        }
        public MainForm(string adm)
        {
            InitializeComponent();
            DelImages();
            this.Visible = false;
            ReadProducts(products);
            AdminForm admin = new AdminForm(this, products);
            admin.ShowDialog();
            products = admin.GetProducts();
            FiltredProducts = new List<Product>(products);
            UpdateForm();
        }

        private void ReadProducts(List<Product> read)
        {
            read.Clear();
            DataBase data = new DataBase();
            data.openBase();

            using (SQLiteCommand cmd = new SQLiteCommand("SELECT * FROM Products", data.getConnection()))
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
        private void UpdateForm()
        {
            try
            {
                Filter.Filtering(filterProd, products, FiltredProducts, ButtonFilter, TextBoxSearch.Text, sortProd);
            }
            catch (ObjectDisposedException ex)
            {
                MessageBox.Show($"Помилка: {ex.Message}");
            }
            panel1.Controls.Clear();
            int y = 30;
            Filter.EmptyProduct(FiltredProducts);
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
                Label labelQuantity = new Label();
                System.Windows.Forms.Button addCartButton = new System.Windows.Forms.Button();
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

                Font quantityFont = new Font("Arial", 12, FontStyle.Bold);
                labelQuantity.Font = quantityFont;
                labelQuantity.Text = $"Ціна {product.PriceSell().ToString("F2")} грн.\nВ наявності";
                labelQuantity.ForeColor = Color.Green;
                labelQuantity.Location = new Point(630, y + 10);
                labelQuantity.AutoSize = true;
                labelQuantity.Width = 150;
                labelQuantity.TextAlign = ContentAlignment.MiddleCenter;

                Font buttonFont = new Font("Arial", 10, FontStyle.Bold);

                addCartButton.Location = new Point(815, y + 10);
                addCartButton.Tag = inx;
                addCartButton.Click += addCartButton_Click;
                addCartButton.Width = 80;
                addCartButton.BackColor = Color.FromArgb(0, 241, 43);
                addCartButton.Height = 80;
                addCartButton.Image = Image.FromFile(".\\Icons\\addCart.png");   
                addCartButton.Text = "";

                infoButton.Font = new Font("Arial", 11, FontStyle.Bold); // Шрифт Arial, розмір 12, жирний стиль
                infoButton.Location = new Point(630, y + 55);
                infoButton.Tag = inx;
                infoButton.Click += InfoButton_Click;
                infoButton.Width = 180;
                infoButton.BackColor = Color.DeepSkyBlue;
                infoButton.Height = 45;
                infoButton.Text = "Характеристики";
                infoButton.ForeColor = Color.Yellow;

                if (product.Quantity() < 1)
                {
                    textBoxInfo.BackColor = Color.Silver;
                    addCartButton.Enabled = false;
                    labelQuantity.Text = $"Ціна {product.PriceSell().ToString("F2")} грн.\nНе в наявності";
                    labelQuantity.ForeColor = Color.Red;
                }
                if(carts.Count != 0)
                {
                    foreach(Cart cart in carts)
                    {
                        if (cart.ProductId() == product.ID())
                        {
                            addCartButton.Image = Image.FromFile(".\\Icons\\inCart.png");
                            addCartButton.BackColor = Control.DefaultBackColor;
                        }
                    }
                }
                panel1.Controls.Add(pictureBox);
                panel1.Controls.Add(textBoxInfo);
                panel1.Controls.Add(addCartButton);
                panel1.Controls.Add(infoButton);
                panel1.Controls.Add(labelQuantity);
                y += 110;
            }
        }
        private void TextBoxInfo_MouseWheel(object sender, MouseEventArgs e)
        {
            int position = panel1.VerticalScroll.Value - e.Delta;

            position = Math.Max(0, Math.Min(position, panel1.VerticalScroll.Maximum));
            panel1.VerticalScroll.Value = position;
            panel1.PerformLayout();
        }

        private void addCartButton_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Button clickedButton = (System.Windows.Forms.Button)sender;
            int inx = (int)clickedButton.Tag;
            Product check = FiltredProducts[inx];
            if (carts.Count != 0)
            {
                foreach (Cart cart in carts)
                {
                    if (cart.ProductId() == check.ID())
                    {
                        CartForm cartForm = new CartForm(carts, this);
                        cartForm.ShowDialog(this);
                        UpdateForm();
                        return;
                    }
                }
            }
            ButtonCart.Checked = true;
            Cart newCart = new Cart();
            newCart.Quantity(1);
            newCart.Popularity(check.Popularity());
            newCart.ProductQuantity(check.Quantity());
            newCart.ProductId(check.ID());
            newCart.Description(check.Description());
            newCart.ImagePath(check.ImagePath());
            newCart.PriceBuy(check.PriceBuy());
            newCart.PriceSell(check.PriceSell());
            carts.Add(newCart);
            CartForm cartForm1 = new CartForm(carts, this);
            cartForm1.ShowDialog(this);
            if (cartForm1.DialogResult == DialogResult.OK)
            {
                ReadProducts(products);
                FiltredProducts = new List<Product>(products);
                TextBoxSearch.Text = "Пошук...";
                ButtonSort.Text = "За популярністю";
                sortProd = "pop";
                filterProd = null;
                ButtonFilter.Checked = false;
            }
            UpdateForm();
        }

        private void InfoButton_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Button clickedButton = (System.Windows.Forms.Button)sender;
            int inx = (int)clickedButton.Tag;
            InfoForm infoForm = new InfoForm(FiltredProducts[inx]);
            infoForm.ShowDialog(this);
        }

        private void TextBoxSearch_Click(object sender, EventArgs e)
        {
            TextBoxSearch.Text = "";
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
                this.FormClosing -= MainForm_FormClosing;
                LoginForm login = new LoginForm();
                login.ShowDialog();
                if (login.DialogResult == DialogResult.OK)
                {
                    this.Visible = false;

                    DataBase data = new DataBase();
                    data.openBase();
                    using (SQLiteCommand cmd = new SQLiteCommand("INSERT INTO `LoginHistory` (`Time`, `Result`, `Password`, `Login`) VALUES (@time, @res, @pass, @log)", data.getConnection()))
                    {
                        DateTime currentTime = DateTime.Now;
                        cmd.Parameters.Add("@time", DbType.String).Value = currentTime;
                        cmd.Parameters.Add("@res", DbType.String).Value = "Успішно";
                        cmd.Parameters.Add("@pass", DbType.String).Value = login.GetPassword();
                        cmd.Parameters.Add("@log", DbType.String).Value = login.GetLogin();
                        cmd.ExecuteNonQuery();
                    }
                    data.closeBase();

                    AdminForm admin = new AdminForm(this, new List<Product>(products));
                    admin.ShowDialog();
                    products = admin.GetProducts();
                    FiltredProducts = new List<Product>(products);
                    UpdateForm();
                }
                else if (login.DialogResult == DialogResult.No)
                {
                    DataBase data = new DataBase();
                    data.openBase();
                    using (SQLiteCommand cmd = new SQLiteCommand("INSERT INTO `LoginHistory` (`Time`, `Result`, `Password`, `Login`) VALUES (@time, @res, @pass, @log)", data.getConnection()))
                    {
                        DateTime currentTime = DateTime.Now;
                        cmd.Parameters.Add("@time", DbType.String).Value = currentTime;
                        cmd.Parameters.Add("@res", DbType.String).Value = "Не успішно";
                        cmd.Parameters.Add("@pass", DbType.String).Value = login.GetPassword();
                        cmd.Parameters.Add("@log", DbType.String).Value = login.GetLogin();
                        cmd.ExecuteNonQuery();
                    }
                    data.closeBase();
                    this.FormClosing += MainForm_FormClosing;
                    timer2.Start();
                }
            }
        }

        private void MainForm_FormClosing(object? sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            time += 1;
        }

        private void ButtonFilter_Click(object sender, EventArgs e)
        {
            using (FilterForm filterForm = new FilterForm(products, filterProd))
            {
                if (filterForm.ShowDialog(this) == DialogResult.OK)
                {
                    filterProd = filterForm.GetFilter();
                    UpdateForm();
                }
            }
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

                HashSet<string> temp = new HashSet<string>();
                DataBase data = new DataBase();
                data.openBase();
                using (SQLiteCommand cmd = new SQLiteCommand("SELECT `Image` FROM `Products`", data.getConnection()))
                {
                    using (SQLiteDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            temp.Add(reader.GetString(reader.GetOrdinal("Image")));
                        }
                    }
                }
                using (SQLiteCommand cmd = new SQLiteCommand("SELECT `Image` FROM `DeletedProducts`", data.getConnection()))
                {
                    using (SQLiteDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            temp.Add(reader.GetString(reader.GetOrdinal("Image")));
                        }
                    }
                }
                using (SQLiteCommand cmd = new SQLiteCommand("SELECT `Image` FROM `Carts`", data.getConnection()))
                {
                    using (SQLiteDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            temp.Add(reader.GetString(reader.GetOrdinal("Image")));
                        }
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

        private void ButtonSearch_Click(object sender, EventArgs e)
        {
            if (TextBoxSearch.Text == "Пошук...")
                return;
            UpdateForm();
        }

        private void TextBoxSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                UpdateForm();
            }
        }

        private void TextBoxSearch_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TextBoxSearch.Text))
            {
                TextBoxSearch.Text = "Пошук...";
                UpdateForm();
            }
        }

        private void TextBoxSearch_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TextBoxSearch.Text))
            {
                TextBoxSearch.Text = "";
                UpdateForm();
            }
        }

        private void MenuItemSortName_Click(object sender, EventArgs e)
        {
            ButtonSort.Text = MenuItemSortName.Text;
            sortProd = "nam";
            UpdateForm();
        }

        private void MenuItemSortPopularity_Click(object sender, EventArgs e)
        {

            ButtonSort.Text = MenuItemSortPopularity.Text;
            sortProd = "pop";
            UpdateForm();
        }

        private void MenuItemSortCheap_Click(object sender, EventArgs e)
        {
            ButtonSort.Text = "Від дешевих до...";
            sortProd = "chp";
            UpdateForm();
        }

        private void MenuItemSortExpensive_Click(object sender, EventArgs e)
        {
            ButtonSort.Text = "Від дорогих до...";
            sortProd = "exp";
            UpdateForm();
        }

        private void ButtonCart_Click(object sender, EventArgs e)
        {
            CartForm cartForm = new CartForm(carts,this);
            cartForm.ShowDialog(this);
            if (cartForm.DialogResult == DialogResult.OK)
            {
                ReadProducts(products);
                FiltredProducts = new List<Product>(products);
                TextBoxSearch.Text = "Пошук...";
                ButtonSort.Text = "За популярністю";
                sortProd = "pop";
                filterProd = null;
                ButtonFilter.Checked = false;
            }
            UpdateForm();
        }
    }
}
