using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmailService_Classes
{
    public class file
    {
        public bool checkExtension(String pNameFile)
        {
            if (pNameFile.EndsWith(".txt") ){
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
