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
        int id = -1;
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
            id = productIn.Id;
            label_ID.Visible = true;
            textBoxName.Text = productIn.Name;
            textBoxDescription.Text = productIn.Description;
            textBoxCountry.Text = productIn.MadeIn;
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

            if (!double.TryParse(textBoxPriceBuy.Text, out priceBuy)||Convert.ToDouble(textBoxPriceBuy.Text) <= 0)
            {
                MessageBox.Show("Неправильне введення поля \"Ціна закупки\"");
                textBoxPriceBuy.Text = "";
                this.DialogResult = DialogResult.None;
                return;
            }
            else if (!double.TryParse(textBoxPriceSell.Text, out priceSell)||Convert.ToDouble(textBoxPriceSell.Text) <= 0)
            {
                MessageBox.Show("Неправильне введення поля \"Ціна продажу\"");
                textBoxPriceSell.Text = "";
                this.DialogResult = DialogResult.None;
                return;
            }
            else if (!double.TryParse(textBoxWeight.Text, out weight)||Convert.ToDouble(textBoxWeight.Text) <= 0)
            {
                MessageBox.Show("Неправильне введення поля \"Маса нетто\"");
                textBoxWeight.Text = "";
                this.DialogResult = DialogResult.None;
                return;
            }
            else if (!int.TryParse(textBoxQuantity.Text, out quantity)||Convert.ToInt32(textBoxQuantity.Text) <= 0)
            {
                MessageBox.Show("Неправильне введення поля \"Кількість\"");
                textBoxQuantity.Text = "";
                this.DialogResult = DialogResult.None;
                return;
            }
            else if(textBoxName.Text.Any(c => !Char.IsLetter(c))){
                MessageBox.Show("Введіть лише літери в поле \"Назва\"");
                this.DialogResult = DialogResult.None;
                return;
            }
            else if (textBoxCountry.Text.Any(c => !Char.IsLetter(c)))
            {
                MessageBox.Show("Введіть лише літери в поле \"Країна-виробник\"");
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
            product.PriceSell = priceSell;
            product.MadeIn = textBoxCountry.Text;
            product.Composition = comboBoxComposition.Text;
            product.Image = pictureBoxImg.Image;
            this.DialogResult = DialogResult.OK;
        }
        private void pictureBoxImg_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBoxImg.BackColor = ColorTranslator.FromHtml("#e4f7ef");

        }
        private void pictureBoxImg_MouseLeave(object sender, EventArgs e)
        {
            pictureBoxImg.BackColor = Color.Transparent;
        }
        private void buttonCancel_MouseHover(object sender, EventArgs e)
        {
            buttonCancel.BackColor = Color.FromArgb(82, 38, 7); 
            buttonCancel.ForeColor = Color.FromArgb(246, 221, 199);
        }
        private void buttonCancel_MouseLeave(object sender, EventArgs e)
        {
            buttonCancel.BackColor = SystemColors.Control;
            buttonCancel.ForeColor = SystemColors.ControlText;
        }
        private void buttonAdd_MouseHover(object sender, EventArgs e)
        {
            buttonAdd.BackColor = Color.FromArgb(82, 38, 7);
            buttonAdd.ForeColor = Color.FromArgb(246, 221, 199);
        }
        private void buttonAdd_MouseLeave(object sender, EventArgs e)
        {
            buttonAdd.BackColor = SystemColors.Control;
            buttonAdd.ForeColor = SystemColors.ControlText;
        }
    }
}
