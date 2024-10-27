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
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CoffeeApp
{
    public partial class AdminForm : Form
    {
        int id = 0;
        List<Product> products = new List<Product>();
        List<Product> FiltredProducts = new List<Product>();
        Filter filterProd = null;
        MainForm MainForm;
        string sortProd = "pop";
        public AdminForm()
        {
            InitializeComponent();
        }
        public AdminForm(MainForm mainForm)
        {
            InitializeComponent();
            MainForm = mainForm;
        }

        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            AddForm form = new AddForm(id);
            form.ShowDialog(this);
            if (form.DialogResult == DialogResult.OK)
            {
                products.Add(form.GetProduct());
                id++;
                Filtering();
            }
        }

        private void UpdateForm()
        {
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

                pictureBox.Image = product.Image;
                pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBox.Location = new Point(10, y);
                pictureBox.Size = new Size(100, 100);

                Font textFont = new Font("Arial", 15);
                textBoxInfo.Text = product.ToString();
                textBoxInfo.Font = textFont;
                textBoxInfo.Location = new Point(120, y + 5);
                textBoxInfo.AutoSize = true;
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
                numericUpDownQuantity.Value = product.Quantity;
                numericUpDownQuantity.ValueChanged += NumericUpDownQuantity_ValueChanged;


                labelQuantity.Font = quantityFont;
                labelQuantity.Text = "Кількість";
                labelQuantity.Location = new Point(630, y + 20);
                labelQuantity.AutoSize = true;

                Font buttonFont = new Font("Arial", 10, FontStyle.Bold);
                delButton.Font = buttonFont;
                delButton.Location = new Point(740, y + 5);
                delButton.Tag = inx;
                delButton.Click += DelButton_Click;
                delButton.Width = 110;
                delButton.BackColor = Color.Red;
                delButton.Height = 45;
                delButton.Text = "Видалити";

                editButton.Font = buttonFont;
                editButton.Location = new Point(740, y + 55);
                editButton.Tag = inx;
                editButton.Click += EditButton_Click;
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
        private void DelButton_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Button clickedButton = (System.Windows.Forms.Button)sender;
            int inx = (int)clickedButton.Tag;
            Product check = FiltredProducts[inx];
            for (int i = 0; i < products.Count; i++)
            {
                if (products[i].Id == check.Id)
                {
                    products.RemoveAt(i);
                }
            }
            Filtering();
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Button clickedButton = (System.Windows.Forms.Button)sender;
            int inx = (int)clickedButton.Tag;
            AddForm edit = new AddForm(FiltredProducts[inx]);
            edit.ShowDialog();
            if (edit.DialogResult == DialogResult.OK)
            {
                Product check = edit.GetProduct();
                for (int i = 0; i < products.Count; i++)
                {
                    if (products[i].Id == check.Id)
                    {
                        products[i] = check;
                    }
                }
            }
            Filtering();
        }

        private void NumericUpDownQuantity_ValueChanged(object sender, EventArgs e)
        {
            NumericUpDown numeric = (NumericUpDown)sender;
            int inx = (int)numeric.Tag;
            FiltredProducts[inx].Quantity = (int)numeric.Value;
            UpdateForm();
        }
        private void Filtering()
        {
            if (filterProd != null)
            {
                ButtonFilter.Checked = true;
                FiltredProducts.Clear();
                string none = "none";
                for (int i = 0; i < products.Count; i++)
                {
                    Product prod = products[i];
                    bool check = true;
                    if (prod.Name != filterProd.Name && filterProd.Name != none) { check = false; }
                    if (prod.Composition != filterProd.Composition && filterProd.Composition != none) { check = false; }
                    if (prod.CoffeeType != filterProd.CoffeeType && filterProd.CoffeeType != none) { check = false; }
                    if (prod.MadeIn != filterProd.MadeIn && filterProd.MadeIn != none) { check = false; }
                    if (prod.PriceSell < filterProd.PriceStart || prod.PriceSell > filterProd.PriceFinish) { check = false; }
                    if (prod.Weight < filterProd.WeightStart || prod.Weight > filterProd.WeightFinish) { check = false; }
                    if (check)
                    {
                        FiltredProducts.Add(prod);
                    }
                }
            }
            else
            {
                ButtonFilter.Checked = false;
                FiltredProducts = new List<Product>(products);
            }
            if (!string.IsNullOrWhiteSpace(TextBoxSearch.Text) && TextBoxSearch.Text != "Пошук...")
            {
                Searching();
            }
            Sorting();
            UpdateForm();
        }
        private void ButtonFilter_Click(object sender, EventArgs e)
        {
            using (FilterForm filterForm = new FilterForm(products, filterProd))
            {
                if (filterForm.ShowDialog(this) == DialogResult.OK)
                {
                    filterProd = filterForm.GetFilter();
                    Filtering();
                }
            }
        }

        private void TextBoxSearch_Click(object sender, EventArgs e)
        {
            TextBoxSearch.Text = "";
        }

        private void TextBoxSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                Filtering();
            }
        }

        private void ButtonSearch_Click(object sender, EventArgs e)
        {
            if (TextBoxSearch.Text == "Пошук...")
                return;
            Filtering();
        }

        private void Searching()
        {
            List<Product> searchProducts = new List<Product>();
            string search = TextBoxSearch.Text.ToLower();
            foreach (Product product in FiltredProducts)
            {
                if (product.Description.ToLower().Contains(search))
                {
                    searchProducts.Add(product);
                }
            }
            FiltredProducts = new List<Product>(searchProducts);
        }

        private void TextBoxSearch_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TextBoxSearch.Text))
            {
                TextBoxSearch.Text = "";
                Filtering();
            }
        }

        private void TextBoxSearch_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TextBoxSearch.Text))
            {
                TextBoxSearch.Text = "Пошук...";
                Filtering();
            }
        }

        private void MenuItemSortName_Click(object sender, EventArgs e)
        {
            ButtonSort.Text = MenuItemSortName.Text;
            sortProd = "nam";
            Filtering();
        }

        private void MenuItemSortPopularity_Click(object sender, EventArgs e)
        {
            ButtonSort.Text = MenuItemSortPopularity.Text;
            sortProd = "pop";
            Filtering();
        }

        private void MenuItemSortCheap_Click(object sender, EventArgs e)
        {
            ButtonSort.Text = "Від дешевих до...";
            sortProd = "chp";
            Filtering();
        }

        private void MenuItemSortExpensive_Click(object sender, EventArgs e)
        {
            ButtonSort.Text = "Від дорогих до...";
            sortProd = "exp";
            Filtering();
        }
        private void Sorting()
        {
            Comparison<Product> comparison = null;

            switch (sortProd)
            {
                case "pop":
                    comparison = (x, y) => y.Popularity.CompareTo(x.Popularity);
                    break;
                case "nam":
                    comparison = (x, y) => string.Compare(x.Name, y.Name);
                    break;
                case "chp":
                    comparison = (x, y) => x.PriceSell.CompareTo(y.PriceSell);
                    break;
                case "exp":
                    comparison = (x, y) => y.PriceSell.CompareTo(x.PriceSell);
                    break;
                default:
                    MessageBox.Show("Error sorting");
                    return;
            }

            if (comparison != null)
            {
                FiltredProducts.Sort(comparison);
            }
        }

        private void AdminForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if(MainForm!=null)
            MainForm.Visible = true;
        }

        private void ButtonDropDB_Click(object sender, EventArgs e)
        {
            ConfirmForm confirm = new ConfirmForm();
            if(confirm.ShowDialog(this) == DialogResult.OK)
            {
                DataBase dataBase = new DataBase();
                dataBase.openBase();
                SQLiteCommand cmd = new SQLiteCommand("DELETE FROM `Admin`",dataBase.getConnection());

                if (cmd.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("База данних успішно скинута.");
                }
                dataBase.closeBase();
                Application.Exit();
            }
        }
    }
}
