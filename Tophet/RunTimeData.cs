using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tophet
{
    class RunTimeData
    {
        //Properties Set
        private string LoginEmail,Password;
        private string Reg_Key;
        public string pre = "Premium";
        public string basic = "Guest Mode";
        public string version = "Prototype 1.0v";

        //Set and Get 

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
      
        //Runtime Data runner
        public RunTimeData() 
        {
            //Account
    
            this.login = "a";
            this.password = "a";
            this.RegistrationKey = "100-200-300-400-500"; 

        }
    }
}
