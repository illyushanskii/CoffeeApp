using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace CoffeeApp
{
    public partial class AddForm : Form
    {
        Product product = new Product();
        int id;
        public AddForm(int Id)
        {
            InitializeComponent();
            id = Id;
            comboBoxType.SelectedIndex = 0;
            comboBoxComposition.SelectedIndex = 0;
            timer1.Start();
        }
        public AddForm(Product productIn)
        {
            InitializeComponent();
            this.Text = "Змінити товар";
            string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"Icons\Edit.ico");
            this.Icon = new Icon(path);
            buttonAdd.Text = "Змінити";
            label_Pop.Text = $"Поп: {productIn.Popularity}";
            label_Pop.Visible = true;
            label_ID.Text = $"ID: {productIn.Id}";
            label_ID.Visible = true;
            textBoxName.Text = productIn.Name;
            textBoxDescription.Text = productIn.Description;
            textBoxCounty.Text = productIn.MadeIn;
            textBoxPriceBuy.Text = productIn.PriceBuy.ToString();
            textBoxPriceSell.Text = productIn.PriceSell.ToString();
            textBoxQuantity.Text = productIn.Quantity.ToString();
            textBoxWeight.Text = productIn.Weight.ToString();
            for (int i = 0; i < comboBoxType.Items.Count; i++)
            {
                string text = comboBoxType.Items[i].ToString();
                if (text == productIn.CoffeeType)
                {
                    comboBoxType.SelectedIndex = i;
                    break;
                }
            }
            for (int i = 0; i < comboBoxComposition.Items.Count; i++)
            {
                string text = comboBoxComposition.Items[i].ToString();
                if (text == productIn.Composition)
                {
                    comboBoxComposition.SelectedIndex = i;
                    break;
                }
            }
            pictureBoxImg.Image = productIn.Image;
            timer1.Start();
        }
        public Product GetProduct()
        {
            return product;
        }
        private void pictureBoxImg_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif|All Files|*.*";
            if (open.ShowDialog() == DialogResult.OK)
            {
                Image img = Image.FromFile(open.FileName);
                pictureBoxImg.Image = img;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            bool result = true;
            foreach (Control ctrl in groupBox1.Controls)
            {
                if (ctrl is TextBox textBox && string.IsNullOrWhiteSpace(textBox.Text))
                {
                    result = false;
                }
            }
            buttonAdd.Enabled = result;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            double priceSell;
            double priceBuy;
            double weight;
            int quantity;

            if (!double.TryParse(textBoxPriceBuy.Text, out priceBuy))
            {
                MessageBox.Show("Неправильне введення поля \"Ціна закупки\"");
                textBoxPriceBuy.Text = "";
                this.DialogResult = DialogResult.None;
                return;
            }
            else if (!double.TryParse(textBoxPriceSell.Text, out priceSell))
            {
                MessageBox.Show("Неправильне введення поля \"Ціна продажу\"");
                textBoxPriceSell.Text = "";
                this.DialogResult = DialogResult.None;
                return;
            }
            else if (!double.TryParse(textBoxWeight.Text, out weight))
            {
                MessageBox.Show("Неправильне введення поля \"Маса нетто\"");
                textBoxWeight.Text = "";
                this.DialogResult = DialogResult.None;
                return;
            }
            else if (!int.TryParse(textBoxQuantity.Text, out quantity))
            {
                MessageBox.Show("Неправильне введення поля \"Кількість\"");
                textBoxQuantity.Text = "";
                this.DialogResult = DialogResult.None;
                return;
            }else if (textBoxDescription.Text.Length > 80)
            {
                MessageBox.Show("Перевищення кількості символів(80) в полі \"Опис\"");
                this.DialogResult = DialogResult.None;
                return;
            }
            product.Description = textBoxDescription.Text;
            product.Name = textBoxName.Text;
            product.CoffeeType = comboBoxType.Text;
            product.Weight = weight;
            product.Quantity = quantity;
            product.Id = id;
            product.PriceBuy = priceBuy;
            product.PriceSell= priceSell;
            product.MadeIn = textBoxCounty.Text;
            product.Composition = comboBoxComposition.Text;
            product.Image = pictureBoxImg.Image;
            this.DialogResult = DialogResult.OK;
        }

        private void pictureBoxImg_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBoxImg.BackColor = Color.Blue;

        }

        private void pictureBoxImg_MouseLeave(object sender, EventArgs e)
        {
            pictureBoxImg.BackColor = Control.DefaultBackColor;
        }
    }
}
