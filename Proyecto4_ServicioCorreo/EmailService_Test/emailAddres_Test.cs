using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmailService_Classes;

namespace EmailService_Test
{
    [TestFixture]
    public class emailAddres_Test
    {
        [TestCase("Yasiell", "yasi1205@hotmail.com")]
        [TestCase("Amanda", null)]
        [TestCase(null, "nels@gmail.com")]
        [TestCase("Susana", "susanagmail.com")]
        public void emailAddress_createNewUser(string pName, string pEmail)
        {
            emailAddress newUser = new emailAddress(pName, pEmail);
            bool correctEmailAddres =  newUser.validEmailAddress(newUser.email);

            Assert.That(newUser.name, Is.Not.EqualTo(null));
            Assert.That(newUser.email, Is.Not.EqualTo(null));
            Assert.IsTrue(correctEmailAddres);
            Assert.IsNotNull(newUser);
        }
    }
}
