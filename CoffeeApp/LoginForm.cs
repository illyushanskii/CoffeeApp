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

namespace CoffeeApp
{
    public partial class LoginForm : Form
    {
        private string login;
        private string loginIn;
        private string password;
        private string passwordIn;
        int count = 0;
        public LoginForm()
        {
            InitializeComponent();
        }
        public string GetLogin()
        {
            return loginIn;
        }
        public string GetPassword() {
            return passwordIn;
        }
        private void buttonLogIn_Click(object sender, EventArgs e)
        {
            loginIn = textBoxLogin.Text;
            passwordIn = textBoxPass.Text;

            if (loginIn != login || passwordIn != password)
            {
                switch (count)
                {
                    case 0:
                        MessageBox.Show("Вхід не здійснено,залишилось 2 спроби!");
                        count++;
                        break;
                    case 1:
                        MessageBox.Show("Вхід не здійснено,залишилась 1 спроба!");
                        count++;
                        break;
                    case 2:
                        MessageBox.Show("Вхід заблоковано на 1хв.");
                        DialogResult = DialogResult.No;
                        this.Close();
                        break;
                }
            }
            else
            {
                DialogResult = DialogResult.OK;
            }
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            DataBase data = new DataBase();
            data.openBase();
            SQLiteCommand cmd = new SQLiteCommand("SELECT Login, Password FROM Admin", data.getConnection());
            using (var reader = cmd.ExecuteReader())
            {
                if (reader.Read())
                {
                    login = reader["Login"].ToString();
                    password = reader["Password"].ToString();
                }
            }
            data.closeBase();
        }
    }
}
