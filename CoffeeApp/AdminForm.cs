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
    public partial class AdminForm : Form
    {
        int id = 0;
        List<Product> products = new List<Product>();
        public AdminForm()
        {
            InitializeComponent();
        }

        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            AddForm form = new AddForm(id);
            form.ShowDialog(this);
            if (form.DialogResult == DialogResult.OK)
            {
                products.Add(form.GetProduct());
            }
            id++;
            
        }

        private void AdminForm_Paint(object sender, PaintEventArgs e)
        {
            panel1.Controls.Clear();
            int y = 30;
            for (int inx = 0; inx < products.Count; inx++)
            {
                Product product = products[inx];
                PictureBox pictureBox = new PictureBox();
                TextBox textBoxInfo = new TextBox();
                NumericUpDown numericUpDownQuantity = new NumericUpDown();
                Label labelQuantity = new Label();
                Button delButton = new Button();
                Button editButton = new Button();

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
                numericUpDownQuantity.Maximum= 100000;
                numericUpDownQuantity.Value = product.Quantity;
                numericUpDownQuantity.ValueChanged += NumericUpDownQuantity_ValueChanged;


                labelQuantity.Font = quantityFont;
                labelQuantity.Text = "Кількість";
                labelQuantity.Location = new Point(630, y + 20);
                labelQuantity.AutoSize = true;

                Font buttonFont = new Font("Arial", 10,FontStyle.Bold);
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
            Button clickedButton = (Button)sender;
            int inx = (int)clickedButton.Tag;
            products.RemoveAt(inx);
            Invalidate();
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;
            int inx = (int)clickedButton.Tag;
            AddForm edit = new AddForm(products[inx]);
            edit.ShowDialog();
            if (edit.DialogResult == DialogResult.OK)
            {
                products[inx] = edit.GetProduct();
            }
            Invalidate();
        }

        private void NumericUpDownQuantity_ValueChanged(object sender, EventArgs e)
        {
            NumericUpDown numeric = (NumericUpDown)sender;
            int inx = (int)numeric.Tag;
            products[inx].Quantity = (int)numeric.Value;
            Invalidate();
        }
    }
}
