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
using static System.Runtime.InteropServices.Marshalling.IIUnknownCacheStrategy;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace CoffeeApp
{
    public partial class ListForm : Form
    {
        List<LogInfo> logInfos = new List<LogInfo>();
        public ListForm()
        {
            InitializeComponent();
            ReadInfo(logInfos);
            UpdateForm();
        }
        private void ReadInfo(List<LogInfo> read)
        {

            read.Clear();
            DataBase data = new DataBase();
            data.openBase();

            using (SQLiteCommand cmd = new SQLiteCommand("SELECT * FROM LoginHistory", data.getConnection()))
            {
                using (SQLiteDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        LogInfo newLogInfo = new LogInfo();
                        newLogInfo.Login(reader.GetString(reader.GetOrdinal("Login")));
                        newLogInfo.Password(reader.GetString(reader.GetOrdinal("Password")));
                        newLogInfo.Result(reader.GetString(reader.GetOrdinal("Result")));
                        newLogInfo.Time(reader.GetString(reader.GetOrdinal("Time")));
                        read.Add(newLogInfo);
                    }
                }
            }
            data.closeBase();
            read.Reverse();
        }

        private void UpdateForm()
        {
            panel1.Controls.Clear();
            Font textFont = new Font("Arial", 15);
            if (logInfos.Count == 0)
            {
                System.Windows.Forms.Label noLogins = new System.Windows.Forms.Label();
                noLogins.Text = "Записів входу немає!";
                noLogins.Font = textFont;
                noLogins.Location = new Point(170, 250);
                noLogins.AutoSize = true;
                panel1.Controls.Add(noLogins);
            }
            int y = 10;
            for (int inx = 0; inx < logInfos.Count; inx++)
            {
                System.Windows.Forms.Label labelInfo = new System.Windows.Forms.Label();

                labelInfo.Text = $"Час: {logInfos[inx].Time()}, Статус: {logInfos[inx].Result()}!{Environment.NewLine}Під логіном: {logInfos[inx].Login()}, Пароль: {logInfos[inx].Password()}";
                labelInfo.Font = textFont;
                labelInfo.ForeColor = logInfos[inx].Result()=="Успішно"?Color.Black:Color.Red;
                labelInfo.Location = new Point(0, y + 5);
                labelInfo.Width = 560;
                labelInfo.Height = 55;
                //labelInfo.MouseWheel += TextBoxInfo_MouseWheel;

                panel1.Controls.Add(labelInfo);
                y += 70;
            }
        }

        //private void TextBoxInfo_MouseWheel(object sender, MouseEventArgs e)
        //{
        //    int position = panel1.VerticalScroll.Value - e.Delta;

        //    position = Math.Max(0, Math.Min(position, panel1.VerticalScroll.Maximum));
        //    panel1.VerticalScroll.Value = position;
        //    panel1.PerformLayout();
        //}
    }
}
