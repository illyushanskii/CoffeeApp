﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;

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

        private void FilterForm_Load(object sender, EventArgs e)
        {
            label1.Left = (this.ClientSize.Width - label1.Width) / 2;
            label1.Top = 10;
            if (products == null)
            {
                return;
            }
            foreach (Product product in products)
            {
                if (maxPrice < product.PriceSell())
                { maxPrice = product.PriceSell(); }
                if (maxWeight < product.Weight())
                { maxWeight = product.Weight(); }
                if (!comboBoxName.Items.Contains(product.Name()))
                {
                    comboBoxName.Items.Add(product.Name());
                }
                if (!comboBoxCountry.Items.Contains(product.MadeIn()))
                {
                    comboBoxCountry.Items.Add(product.MadeIn());
                }
                if (!comboBoxType.Items.Contains(product.Type()))
                {
                    comboBoxType.Items.Add(product.Type());
                }
                if (!comboBoxComposition.Items.Contains(product.Composition()))
                {
                    comboBoxComposition.Items.Add(product.Composition());
                }
            }

            numericPriceMax.Value = (decimal)maxPrice;
            numericWeightMax.Value = (decimal)maxWeight;

            if (filterIn != null)
            {
                comboBoxCountry.SelectedIndex = comboBoxCountry.Items.IndexOf(filterIn.MadeIn());
                comboBoxName.SelectedIndex = comboBoxName.Items.IndexOf(filterIn.Name());
                comboBoxType.SelectedIndex = comboBoxType.Items.IndexOf(filterIn.Type());
                comboBoxComposition.SelectedIndex = comboBoxComposition.Items.IndexOf(filterIn.Composition());
                numericPriceMax.Value = (decimal)filterIn.PriceFinish();
                numericPriceMin.Value = (decimal)filterIn.PriceStart();
                numericWeightMin.Value = (decimal)filterIn.WeightStart();
                numericWeightMax.Value = (decimal)filterIn.WeightFinish();
            }
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            filter.MadeIn(comboBoxCountry.Text);
            filter.Name(comboBoxName.Text);
            filter.PriceStart(minPrice);
            filter.PriceFinish(maxPrice);
            filter.WeightStart(minWeight);
            filter.WeightFinish(maxWeight);
            filter.Type(comboBoxType.Text);
            filter.Composition(comboBoxComposition.Text);
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
            string item = "";
            comboBox.Items.Clear();
            comboBox.Items.Add("none");

            foreach (Product prod in products)
            {
                item = mode == "Name" ? prod.Name() : prod.MadeIn();
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

        private void comboBoxName_Leave(object sender, EventArgs e)
        {
            if (!comboBoxName.Items.Contains(comboBoxName.Text))
            {
                comboBoxName.Text = "none";
            }
        }

        private void comboBoxCountry_Leave(object sender, EventArgs e)
        {
            if (!comboBoxCountry.Items.Contains(comboBoxCountry.Text))
            {
                comboBoxCountry.Text = "none";
            }
        }
        private void buttonReset_MouseLeave(object sender, EventArgs e)
        {
            buttonReset.ForeColor = Color.FromArgb(246, 221, 199);
            buttonReset.BackColor = Color.FromArgb(82, 38, 7);
        }

        private void buttonOK_MouseHover(object sender, EventArgs e)
        {
            buttonOK.BackColor = Color.FromArgb(82, 38, 7);
            buttonOK.ForeColor = Color.FromArgb(246, 221, 199);
        }

        private void buttonOK_MouseLeave(object sender, EventArgs e)
        {
            buttonOK.ForeColor = Color.FromArgb(246, 221, 199);
            buttonOK.BackColor = Color.FromArgb(82, 38, 7);
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void buttonReset_MouseEnter(object sender, EventArgs e)
        {
            buttonReset.ForeColor = Color.FromArgb(82, 38, 7);
            buttonReset.BackColor = Color.FromArgb(246, 221, 199);
        }

        private void buttonOK_MouseEnter(object sender, EventArgs e)
        {
            buttonOK.ForeColor = Color.FromArgb(82, 38, 7);
            buttonOK.BackColor = Color.FromArgb(246, 221, 199);
        }
    }
}
