using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoffeeApp
{
    public partial class InfoForm : Form
    {
        public InfoForm(Product productIn)
        {
            InitializeComponent();
            textBoxName.Text = productIn.Name();
            textBoxCountry.Text = productIn.MadeIn();
            textBoxPriceSell.Text = productIn.PriceSell().ToString("F2");
            textBoxWeight.Text = productIn.Weight().ToString();
            textBoxComposition.Text = productIn.Composition();
            textBoxType.Text = productIn.Type().ToString();
            pictureBoxImg.Image = Image.FromFile(productIn.ImagePath());
        }
    }
}
