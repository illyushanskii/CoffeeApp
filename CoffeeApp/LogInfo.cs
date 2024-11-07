using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeApp
{
    public class LogInfo
    {
        private string login = "";
        private string password = "";
        private string result = "";
        private string time = "";
        public void Login(string log) { login = log; }
        public string Login() { return login; }
        public void Password(string pas) { password = pas; }
        public string Password() { return password; }
        public void Result(string res) { result = res; }
        public string Result() { return result; }
        public void Time(string tim) { time = tim; }
        public string Time() { return time; }
    }
}
