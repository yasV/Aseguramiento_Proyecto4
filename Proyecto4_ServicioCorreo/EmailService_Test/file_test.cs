using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmailService_Classes;
using NSubstitute;

namespace EmailService_Test
{
    [TestFixture]
    public class file_test
    {
        [TestCase("WeeklyNotification.cvs")]
        [TestCase("WeeklyNotification.txt")]
        public void file_checkExtension(string nombreArchivo)
        {
            file fileNotification = new file();
            bool checkExtention = fileNotification.checkExtension(nombreArchivo);
            Assert.IsTrue(checkExtention);
        }
    }
}
