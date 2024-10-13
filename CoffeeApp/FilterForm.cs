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
    public partial class FilterForm : Form
    {
        public FilterForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void FilterForm_Paint(object sender, PaintEventArgs e)
        {
            int y = 118;
            Graphics g = e.Graphics;
            Pen pen = new Pen(Color.Gray, 4);
            pen.StartCap = System.Drawing.Drawing2D.LineCap.Round;
            pen.EndCap = System.Drawing.Drawing2D.LineCap.Round;
            for(int i = 0; i < 5; i++) {
                g.DrawLine(pen, new Point(16, y), new Point(275, y));
                y += 82;
            }
           
        }

        private void buttonNone_Click(object sender, EventArgs e)
        {

        }

        private void FilterForm_Load(object sender, EventArgs e)
        {

        }
    }
}
