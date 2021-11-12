using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tophet
{
    class RunTimeData
    {
        private string LoginEmail,Password;
        private string Reg_Key;
        public string pre = "Premium";
        public string basic = "Guest";
        public string version = "Prototype 1.0v";
        public string RuleLabel = "";

        public string ruleLabel
        {
            get { return RuleLabel; }
            set { RuleLabel = value; }
        }

        public string login
        {
            get { return LoginEmail; }
            set { LoginEmail = value; }
        }
        public string password 
        {
            get { return Password; }
            set { Password = value; }
        }

        public string RegistrationKey 
        {
            get { return Reg_Key; }
            set { Reg_Key = value; }
        }
      

        public RunTimeData() 
        {
            //Account
            this.login = "Admin@gmail.com";
            this.password = "admin";
            this.RegistrationKey = "100-200-300-400-500";
        }
    }
}
