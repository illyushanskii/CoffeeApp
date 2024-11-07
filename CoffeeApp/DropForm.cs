using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoffeeApp
{
    public partial class DropForm : Form
    {
        public DropForm()
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
        private void BoxAll_CheckedChanged(object sender, EventArgs e)
        {
            if (boxAll.Checked)
            {
                boxCasa.Checked = true;
                boxDeletedProducts.Checked = true;
                boxLoginHistory.Checked = true;
                BoxAdmin.Checked = true;
                boxProducts.Checked = true;
            }
            else
            {
                boxCasa.Checked = false;
                boxDeletedProducts.Checked = false;
                boxLoginHistory.Checked = false;
                BoxAdmin.Checked = false;
                boxProducts.Checked = false;
            }
        }
        private void BoxAdmin_CheckedChanged(object sender, EventArgs e)
        {
            if (BoxAdmin.Checked)
            {
                boxLoginHistory.Checked = true;
            }
        }
        private void boxProducts_CheckedChanged(object sender, EventArgs e)
        {
            if (boxProducts.Checked)
            {
                boxDeletedProducts.Checked = true;
            }
        }
        private void confirm_Click(object sender, EventArgs e)
        {
            DataBase dataBase = new DataBase();
            dataBase.openBase();
            using (SQLiteCommand cmd = new SQLiteCommand("", dataBase.getConnection()))
            {
                if (boxCasa.Checked)
                {
                    cmd.CommandText = "DELETE FROM Carts";
                    cmd.ExecuteNonQuery();
                }
                if (BoxAdmin.Checked)
                {
                    cmd.CommandText = "DELETE FROM Admin";
                    cmd.ExecuteNonQuery();
                }
                if (boxLoginHistory.Checked)
                {
                    cmd.CommandText = "DELETE FROM LoginHistory";
                    cmd.ExecuteNonQuery();
                }
                if (boxProducts.Checked)
                {
                    cmd.CommandText = "DELETE FROM Products";
                    cmd.ExecuteNonQuery();
                }
                if (boxDeletedProducts.Checked)
                {
                    cmd.CommandText = "DELETE FROM DeletedProducts";
                    cmd.ExecuteNonQuery();
                }
            }
            dataBase.closeBase();
            MessageBox.Show("База даних успішно оновлена!");
            Application.Restart();
        }
    }
}
