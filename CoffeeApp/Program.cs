using System.Data.SQLite;
namespace CoffeeApp
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            DataBase data = new DataBase();
            data.openBase();
            SQLiteCommand cmd = new SQLiteCommand("SELECT EXISTS(SELECT 1 FROM `Admin`)", data.getConnection());
            bool check = Convert.ToBoolean(cmd.ExecuteScalar());
            data.closeBase();
            if (check)
            {
                Application.Run(new MainForm());
            }
            else
            {
                RegisterForm regForm = new RegisterForm();
                regForm.ShowDialog();
                if(regForm.DialogResult == DialogResult.OK)
                {
                    try
                    {
                        Application.Run(new MainForm("cv"));
                    }
                    catch (ObjectDisposedException ex)
                    {
                        MessageBox.Show($"Помилка: {ex.Message}");
                    }
                }
            }
        }
    }
}