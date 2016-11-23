using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmailService_Classes;
using Rhino.Mocks;


namespace EmailService_Test
{
    [TestFixture]
    public class createNotificationFile_Test
    {
        [TestCase ("12:15","Notifi1")]
        [TestCase("12:25", "Notifi2")]
        [TestCase("15:15", "Notifi3")]
        public void createNotificationDaily_Test(string pHora, string pMensaje)
        {
            IFileSystem file = MockRepository.GenerateStrictMock<IFileSystem>();
            file.Expect(x => x.OpenFile("archivo1.txt")).Return(true);
            createNotification_FromFile notif = new createNotification_FromFile(file);
            notif.createNotificationDaily(pHora, pMensaje);
            file.Expect(x => x.writeFile("archivo1.txt","#/"+pHora+"/"+pMensaje)).Return(true);
            file.VerifyAllExpectations();


        }

        [TestCase(5,"1:15", "Notifi4")]
        [TestCase(28,"9:15", "Notifi5")]
        [TestCase(15,"22:15pm", "Notifi6")]
        public void createNotificationMonthly_Test(int pDia, string pHora, string pMensaje)
        {
            IFileSystem file = MockRepository.GenerateStrictMock<IFileSystem>();
            file.Expect(x => x.OpenFile("archivo1.txt")).Return(true);
            createNotification_FromFile notif = new createNotification_FromFile(file);
            notif.createNotificationMonthly(pDia, pHora, pMensaje);
            file.Expect(x => x.writeFile("archivo1.txt", pDia+ "/" + pHora + "/" + pMensaje)).Return(true);
            file.VerifyAllExpectations();
        }

        [TestCase(5, "1:15", "Notifi4")]
        [TestCase(2, "9:15", "Notifi5")]
        [TestCase(7, "22:15pm", "Notifi6")]
        public void createNotificationWeekly_Test(int pDia, string pHora, string pMensaje)
        {
            IFileSystem file = MockRepository.GenerateStrictMock<IFileSystem>();
            file.Expect(x => x.OpenFile("archivo1.txt")).Return(true);
            createNotification_FromFile notif = new createNotification_FromFile(file);
            notif.createNotificationMonthly(pDia, pHora, pMensaje);
            file.Expect(x => x.writeFile("archivo1.txt", pDia + "/" + pHora + "/" + pMensaje)).Return(true);
            file.VerifyAllExpectations();
        }

    }
}
