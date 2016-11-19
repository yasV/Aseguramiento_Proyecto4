using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmailService_Classes
{
    public class emailAddress
    {
        public string name;
        public string email;

        public emailAddress(string pName, string pEmail)
        {
            name = pName;
            email = pEmail;
        }

        public bool validEmailAddress(String pEmail)
        {
            if (pEmail.Contains("@"))
                return true;
            else
                return false;
        }
    }
}
