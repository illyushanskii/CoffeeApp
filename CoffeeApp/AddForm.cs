using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Data.SQLite;
using static System.Net.Mime.MediaTypeNames;
using static System.Data.Entity.Infrastructure.Design.Executor;
using System.IO;
using System.Data.SqlClient;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CoffeeApp
{
    public partial class AddForm : Form
    {
        Product product;
        int id;
        string imgPath = ".\\Icons\\image.png";
        string newImgPath = "";
        string info = "";
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
            product = productIn;
            buttonAdd.Text = "Змінити";
            label_Pop.Text = $"Поп: {productIn.Popularity()}";
            label_Pop.Visible = true;
            label_ID.Text = $"ID: {productIn.ID()}";
            id = productIn.ID();
            label_ID.Visible = true;
            textBoxName.Text = productIn.Name();
            textBoxDescription.Text = productIn.Description();
            textBoxCountry.Text = productIn.MadeIn();
            textBoxPriceBuy.Text = productIn.PriceBuy().ToString("F2");
            textBoxPriceSell.Text = productIn.PriceSell().ToString("F2");
            textBoxQuantity.Text = productIn.Quantity().ToString();
            textBoxWeight.Text = productIn.Weight().ToString();
            for (int i = 0; i < comboBoxType.Items.Count; i++)
            {
                string text = comboBoxType.Items[i].ToString();
                if (text == productIn.Type())
                {
                    comboBoxType.SelectedIndex = i;
                    break;
                }
            }
            for (int i = 0; i < comboBoxComposition.Items.Count; i++)
            {
                string text = comboBoxComposition.Items[i].ToString();
                if (text == productIn.Composition())
                {
                    comboBoxComposition.SelectedIndex = i;
                    break;
                }
            }
            pictureBoxImg.Image = System.Drawing.Image.FromFile(productIn.ImagePath());
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
                newImgPath = open.FileName;
                System.Drawing.Image img = System.Drawing.Image.FromFile(newImgPath);
                pictureBoxImg.Image = img;
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            bool result = true;
            foreach (Control ctrl in groupBox1.Controls)
            {
                if (ctrl is System.Windows.Forms.TextBox textBox && string.IsNullOrWhiteSpace(textBox.Text))
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

            if (!double.TryParse(textBoxPriceBuy.Text, out priceBuy) || Convert.ToDouble(textBoxPriceBuy.Text) <= 0)
            {
                MessageBox.Show("Неправильне введення поля \"Ціна закупки\"");
                textBoxPriceBuy.Text = "";
                this.DialogResult = DialogResult.None;
                return;
            }
            else if (!double.TryParse(textBoxPriceSell.Text, out priceSell) || Convert.ToDouble(textBoxPriceSell.Text) <= 0)
            {
                MessageBox.Show("Неправильне введення поля \"Ціна продажу\"");
                textBoxPriceSell.Text = "";
                this.DialogResult = DialogResult.None;
                return;
            }
            else if (!double.TryParse(textBoxWeight.Text, out weight) || Convert.ToDouble(textBoxWeight.Text) <= 0)
            {
                MessageBox.Show("Неправильне введення поля \"Маса нетто\"");
                textBoxWeight.Text = "";
                this.DialogResult = DialogResult.None;
                return;
            }
            else if (!int.TryParse(textBoxQuantity.Text, out quantity) || Convert.ToInt32(textBoxQuantity.Text) <= 0)
            {
                MessageBox.Show("Неправильне введення поля \"Кількість\"");
                textBoxQuantity.Text = "";
                this.DialogResult = DialogResult.None;
                return;
            }
            else if (textBoxName.Text.Any(c => !Char.IsLetter(c)))
            {
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

            if (newImgPath != "")
            {
                int backSlash = newImgPath.LastIndexOf('\\');

                string fileName = newImgPath.Substring(backSlash + 1, newImgPath.Length - backSlash - 1);
                string folderPath = ".\\\\ProductsImage";
                Directory.CreateDirectory(folderPath);
                imgPath = Path.Combine(folderPath, fileName);
                if (!CheckPath(imgPath))
                {
                    pictureBoxImg.Image.Save(imgPath);
                }
            }
            else if (product != null)
            {
                imgPath = product.ImagePath();
            }

            DataBase data = new DataBase();
            data.openBase();

            using (SQLiteCommand cmd = product == null
                ? new SQLiteCommand("INSERT INTO `Products` (`ID`, `Name`,`Popularity`,`Description`,`PriceBuy`,`PriceSell`,`Quantity`,`Weight`,`Type`,`MadeIn`,`Composition`,`Image`) VALUES (@id, @name, @popularity, @description, @priceBuy, @priceSell, @quantity, @weight, @type, @madeIn, @composition, @image)", data.getConnection())
                : new SQLiteCommand("UPDATE `Products` SET `Name` = @name, `Description` = @description, `PriceBuy` = @priceBuy, `PriceSell` = @priceSell, `Quantity` = @quantity, `Weight` = @weight, `Type` = @type, `MadeIn` = @madeIn, `Composition` = @composition, `Image` = @image WHERE id = @id", data.getConnection()))
            {
                cmd.Parameters.Add("@id", DbType.Int32).Value = id;
                cmd.Parameters.Add("@name", DbType.String).Value = textBoxName.Text;
                cmd.Parameters.Add("@description", DbType.String).Value = textBoxDescription.Text;
                cmd.Parameters.Add("@priceBuy", DbType.Double).Value = priceBuy;
                cmd.Parameters.Add("@priceSell", DbType.Double).Value = priceSell;
                cmd.Parameters.Add("@quantity", DbType.Int32).Value = quantity;
                cmd.Parameters.Add("@weight", DbType.Double).Value = weight;
                cmd.Parameters.Add("@type", DbType.String).Value = comboBoxType.Text;
                cmd.Parameters.Add("@madeIn", DbType.String).Value = textBoxCountry.Text;
                cmd.Parameters.Add("@composition", DbType.String).Value = comboBoxComposition.Text;
                cmd.Parameters.Add("@image", DbType.String).Value = imgPath;

                if (product == null)
                {
                    cmd.Parameters.Add("@popularity", DbType.Int32).Value = 0;
                }

                if (cmd.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Успішно!");
                }
            }

            data.closeBase();

            int pop = 0;
            if (product != null)
            {
                pop = product.Popularity();
            }
            product = new Product();
            product.Description(textBoxDescription.Text);
            product.Popularity(pop);
            product.Name(textBoxName.Text);
            product.Type(comboBoxType.Text);
            product.Weight(weight);
            product.Quantity(quantity);
            product.ID(id);
            product.PriceBuy(priceBuy);
            product.PriceSell(priceSell);
            product.MadeIn(textBoxCountry.Text);
            product.Composition(comboBoxComposition.Text);
            product.ImagePath(imgPath);

            this.DialogResult = DialogResult.OK;
        }

        private bool CheckPath(string path)
        {
            bool result = false;
            if (path != "")
            {
                DataBase data = new DataBase();
                data.openBase();

                using (SQLiteCommand cmd = new SQLiteCommand("SELECT 1 FROM `Products` WHERE `Image` = @image LIMIT 1", data.getConnection()))
                {
                    cmd.Parameters.Add("@image", DbType.String).Value = path;
                    var check = cmd.ExecuteScalar();
                    result = check != null;
                }
                data.closeBase();
            }
            return result;
        }
        private void pictureBoxImg_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBoxImg.BackColor = ColorTranslator.FromHtml("#e4f7ef");

        }
        private void pictureBoxImg_MouseLeave(object sender, EventArgs e)
        {
            pictureBoxImg.BackColor = Color.Transparent;
        }
        private void buttonCancel_MouseEnter(object sender, EventArgs e)
        {
            buttonCancel.BackColor = Color.FromArgb(82, 38, 7);
            buttonCancel.ForeColor = Color.FromArgb(246, 221, 199);
        }
        private void buttonCancel_MouseLeave(object sender, EventArgs e)
        {
            buttonCancel.BackColor = SystemColors.Control;
            buttonCancel.ForeColor = SystemColors.ControlText;
        }
        private void buttonAdd_MouseEnter(object sender, EventArgs e)
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
