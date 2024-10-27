using System;
using System.Data.SQLite;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace CoffeeApp
{
    public partial class MainForm : Form
    {
        int time = 0;
        int entry = 0;
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
            if (time >= 5 && entry == 0)
            {
                LoginForm login = new LoginForm();
                login.ShowDialog();
                if (login.DialogResult == DialogResult.OK)
                {
                    this.Visible = false;
                    AdminForm admin = new AdminForm(this);
                    admin.ShowDialog();
                  
                }
                else if (login.DialogResult == DialogResult.No)
                {
                    MessageBox.Show("No");
                    timer2.Start();
                }
            }
            else if(time >= 5)
            {
                MessageBox.Show(entry.ToString());
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            time += 1;
        }

        private void ButtonFilter_Click(object sender, EventArgs e)
        {
            //FilterForm filter = new FilterForm();
            //filter.ShowDialog();
        }

        private void ButtonSort_ButtonClick(object sender, EventArgs e)
        {

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (entry == 60)
            {
                timer2.Stop();
                entry = 0;
                return;
            }
            else
            {
                entry++;
            }
        }
    }
}
