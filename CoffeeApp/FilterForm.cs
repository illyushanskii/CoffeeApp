using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CoffeeApp
{
    public partial class FilterForm : Form
    {
        List<Product> products;
        Filter filter = new Filter();
        Filter filterIn = new Filter();
        double maxPrice = 0;
        double maxWeight = 0;
        double minPrice = 0;
        double minWeight = 0;
        public FilterForm(List<Product> productsIn, Filter FilterIn)
        {
            InitializeComponent();
            this.products = productsIn;
            filterIn = FilterIn;
            comboBoxCountry.SelectedIndex = 0;
            comboBoxName.SelectedIndex = 0;
            comboBoxType.SelectedIndex = 0;
            comboBoxComposition.SelectedIndex = 0;
        }
        public Filter GetFilter()
        {
            return filter;
        }

        private void FilterForm_Paint(object sender, PaintEventArgs e)
        {
            int y = 118;
            Graphics g = e.Graphics;
            Pen pen = new Pen(Color.Gray, 4);
            pen.StartCap = System.Drawing.Drawing2D.LineCap.Round;
            pen.EndCap = System.Drawing.Drawing2D.LineCap.Round;
            for (int i = 0; i < 6; i++)
            {
                g.DrawLine(pen, new Point(16, y), new Point(275, y));
                y += 82;
            }

        }

        private void FilterForm_Load(object sender, EventArgs e)
        {
            if (products == null)
            {
                return;
            }
            foreach (Product product in products)
            {
                if (maxPrice < product.PriceSell)
                { maxPrice = product.PriceSell; }
                if (maxWeight < product.Weight)
                { maxWeight = product.Weight; }
                if (!comboBoxName.Items.Contains(product.Name))
                {
                    comboBoxName.Items.Add(product.Name);
                }
                if (!comboBoxCountry.Items.Contains(product.MadeIn))
                {
                    comboBoxCountry.Items.Add(product.MadeIn);
                }
                if (!comboBoxType.Items.Contains(product.CoffeeType))
                {
                    comboBoxType.Items.Add(product.CoffeeType);
                }
                if (!comboBoxComposition.Items.Contains(product.Composition))
                {
                    comboBoxComposition.Items.Add(product.Composition);
                }
            }

            numericPriceMax.Value = (decimal)maxPrice;
            numericWeightMax.Value = (decimal)maxWeight;

            if (filterIn != null)
            { 
                comboBoxCountry.SelectedIndex = comboBoxCountry.Items.IndexOf(filterIn.MadeIn);
                comboBoxName.SelectedIndex = comboBoxName.Items.IndexOf(filterIn.Name);
                comboBoxType.SelectedIndex = comboBoxType.Items.IndexOf(filterIn.CoffeeType);
                comboBoxComposition.SelectedIndex = comboBoxComposition.Items.IndexOf(filterIn.Composition);
                numericPriceMax.Value = (decimal)filterIn.PriceFinish;
                numericPriceMin.Value = (decimal)filterIn.PriceStart;
                numericWeightMin.Value = (decimal)filterIn.WeightStart;
                numericWeightMax.Value = (decimal)filterIn.WeightFinish;
            }
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            if (!comboBoxName.Items.Contains(comboBoxName.Text))
            {
                MessageBox.Show("Оберіть значення в полі \"Назва:\".");
                this.DialogResult = DialogResult.None;
                return;
            }
            if (!comboBoxCountry.Items.Contains(comboBoxCountry.Text))
            {
                MessageBox.Show("Оберіть значення в полі \"Країна-виробник:\".");
                this.DialogResult = DialogResult.None;
                return;
            }
            filter.MadeIn = comboBoxCountry.Text;
            filter.Name = comboBoxName.Text;
            filter.PriceStart = minPrice;
            filter.PriceFinish = maxPrice;
            filter.WeightStart = minWeight;
            filter.WeightFinish = maxWeight;
            filter.CoffeeType = comboBoxType.Text;
            filter.Composition = comboBoxComposition.Text;
        }

        private void numericPriceMin_ValueChanged(object sender, EventArgs e)
        {
            minPrice = (double)numericPriceMin.Value;
        }

        private void numericPriceMax_ValueChanged(object sender, EventArgs e)
        {
            maxPrice = (double)numericPriceMax.Value;
        }

        private void numericWeightMin_ValueChanged(object sender, EventArgs e)
        {
            minWeight = (double)numericWeightMin.Value;
        }

        private void numericWeightMax_ValueChanged(object sender, EventArgs e)
        {
            maxWeight = (double)numericWeightMax.Value;
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            filter = null;
        }

        private void comboBoxName_TextUpdate(object sender, EventArgs e)
        {
            resetComboBox(comboBoxName, "Name");
            searchComboBox(comboBoxName);
        }

        private void comboBoxName_Click(object sender, EventArgs e)
        {
            resetComboBox(comboBoxName, "Name");
            comboBoxName.Text = "";
            comboBoxName.DroppedDown = true;
        }

        private void comboBoxCountry_TextUpdate(object sender, EventArgs e)
        {
            resetComboBox(comboBoxCountry, "Country");
            searchComboBox(comboBoxCountry);
        }

        private void comboBoxCountry_Click(object sender, EventArgs e)
        {
            resetComboBox(comboBoxCountry, "Country");
            comboBoxCountry.Text = "";
            comboBoxCountry.DroppedDown = true;
        }
        private void resetComboBox(System.Windows.Forms.ComboBox comboBox, string mode)
        {
            string item ="";
            comboBox.Items.Clear();
            comboBox.Items.Add("none");

            foreach (Product prod in products)
            {
                item = mode == "Name"?prod.Name:prod.MadeIn;
                if (!comboBox.Items.Contains(item))
                {
                    comboBox.Items.Add(item);
                }
            }
            
        }
        private void searchComboBox(System.Windows.Forms.ComboBox comboBox)
        {
            List<string> newList = new List<string>();

            if (!string.IsNullOrEmpty(comboBox.Text))
            {
                string search = comboBox.Text.ToLower();

                for (int i = 0; i < comboBox.Items.Count; i++)
                {
                    string item = comboBox.Items[i].ToString();
                    if (item.ToLower().Contains(search))
                    {
                        newList.Add(item);
                    }
                }
                comboBox.Items.Clear();
                if (newList.Count > 0)
                {
                    comboBox.Items.AddRange(newList.ToArray());
                    comboBox.DroppedDown = true;
                    comboBox.SelectionStart = comboBox.Text.Length;
                }
                else
                {
                    comboBox.Items.Add("none");
                    comboBox.DroppedDown = true;
                    comboBox.SelectionStart = comboBox.Text.Length;
                }
            }
            else
            {
                comboBox.DroppedDown = true;
            }
        }
    }
}
