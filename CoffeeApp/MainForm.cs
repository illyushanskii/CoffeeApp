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
    public partial class MainForm : Form
    {
        int time = 0;
        public MainForm()
        {
            InitializeComponent();
        }

        private void toolStripComboBox1_Click(object sender, EventArgs e)
        {

        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void TextBoxSearch_Click(object sender, EventArgs e)
        {

        }

        private void LabelAdmin_MouseDown(object sender, MouseEventArgs e)
        {
            time = 0;
            timer1.Start();
        }

        private void LabelAdmin_MouseUp(object sender, MouseEventArgs e)
        {
            timer1.Stop();
            if (time >= 5)
            {
                MessageBox.Show("Admin");
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            time += 1;
        }

        private void ButtonFilter_Click(object sender, EventArgs e)
        {
            FilterForm filter = new FilterForm();
            filter.ShowDialog();
        }
    }
}
