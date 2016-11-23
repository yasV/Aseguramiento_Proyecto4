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
    public class notification_Test
    {
        [TestCase(null, 10)]
        [TestCase("This is a test", 11)]
        [TestCase("This is a test", 26)]
        [TestCase("This is a test", -1)]
        public void notification_createNewNotification(String pMensaje, int pHora)
        {
            notification noti = new notification(pMensaje, pHora);

            Assert.That(noti.mensaje, Is.Not.EqualTo(null));
            Assert.Less(noti.hora, 24);
            Assert.GreaterOrEqual(noti.hora, 0);
            Assert.IsNotNull(noti);
        }
    }
}
