using System.Data.SQLite;
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
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();

        }
        private void buttonLogIn_Click(object sender, EventArgs e)
        {
            if (textBoxPass.Text != textBoxPassCheck.Text)
            {
                MessageBox.Show("Пароль не підтвердженно!");
                textBoxPassCheck.Text = "";
                DialogResult = DialogResult.None;
                return;
            }
            else if (string.IsNullOrWhiteSpace(textBoxPass.Text) || string.IsNullOrWhiteSpace(textBoxPassCheck.Text) || string.IsNullOrWhiteSpace(textBoxLogin.Text))
            {
                MessageBox.Show("Заповніть усі поля");
                DialogResult = DialogResult.None;
                return;
            }
            else
            {
                DataBase data = new DataBase();
                data.openBase();
                using (SQLiteCommand cmd = new SQLiteCommand("INSERT INTO `Admin` (`Login`, `Password`) VALUES (@log, @pass)", data.getConnection()))
                {
                    cmd.Parameters.Add("@log", DbType.String).Value = textBoxLogin.Text;
                    cmd.Parameters.Add("@pass", DbType.String).Value = textBoxPass.Text;
                    if (cmd.ExecuteNonQuery() == 1)
                        MessageBox.Show("Реєстрація успішна!");
                }
                data.closeBase();
                DialogResult = DialogResult.OK;
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
