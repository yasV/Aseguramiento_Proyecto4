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
    public class servicesInterface_Test
    {
        List<notification> notificationList = new List<notification>();
        List<notification> orderList = new List<notification>();

        [SetUp]
        public void initTest()
        {
            orderList.Add(new notification("Noti1", 9));
            orderList.Add(new notification("Noti2", 14));
            orderList.Add(new notification("Noti3", 22));

            notificationList.Add(new notification("Noti2", 14));
            notificationList.Add(new notification("Noti3", 22));
            notificationList.Add(new notification("Noti1", 9));
        }

        [Test]
        public void servicesInterface_function_ExecuteNotification()
        {
            emailAddress user = new emailAddress("Juana", "juana@gmail.com");

            var execute = Substitute.For<servicesInterface>();
            execute.executeNotification();
            execute.sendEmail(user, "This is a new Message");

            Received.InOrder(() => {
                execute.Received().executeNotification();
                execute.Received().sendEmail(user, "This is a new Message");
            });
        }

        [Test]
        public void notification_orderNotificationList()
        {
            var orderListFunction = Substitute.For<servicesInterface>();
            orderListFunction.orderNotificationList(notificationList).Returns(orderList);
            Assert.That(orderListFunction.orderNotificationList(notificationList), Is.EqualTo(orderList));
        }
    }
}

