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
    public partial class ConfirmForm : Form
    {
        public ConfirmForm()
        {
            InitializeComponent();
        }


        private void confirm_MouseEnter(object sender, EventArgs e)
        {
            confirm.BackColor = Color.Red;
            confirm.ForeColor = Color.White;
        }

        private void confirm_MouseLeave(object sender, EventArgs e)
        {
            confirm.BackColor = SystemColors.Control;
            confirm.ForeColor = SystemColors.ControlText;
        }


        private void button1_MouseEnter(object sender, EventArgs e)
        {
            button1.ForeColor = Color.White;
            button1.BackColor = Color.Green;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.ForeColor = Control.DefaultForeColor;
            button1.BackColor = Control.DefaultBackColor;
        }
    }
}
