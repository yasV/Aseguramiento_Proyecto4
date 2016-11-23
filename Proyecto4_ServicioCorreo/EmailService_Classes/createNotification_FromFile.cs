using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace EmailService_Classes
{
   public class createNotification_FromFile : servicesInterface
    {
        IFileSystem file;
        public createNotification_FromFile (IFileSystem pFile) {
            file = pFile;
        }
        public void createNotificationDaily(string hora, string mensaje)
        {
            throw new NotImplementedException();
        }

        public void createNotificationMonthly(int dia, string hora, string mensaje)
        {
            throw new NotImplementedException();
        }

        public void createNotificationWeekly(int dia, string hora, string mensaje)
        {
            throw new NotImplementedException();
        }

        public void executeNotification()
        {
            throw new NotImplementedException();
        }

        public int getintent()
        {
            throw new NotImplementedException();
        }

        public void reSendEmail(List<emailAddress> emailList, string mensaje, int numIntentos)
        {
            throw new NotImplementedException();
        }

        public bool sendEmail(emailAddress emailList, string mensaje)
        {
            throw new NotImplementedException();
        }

        public bool sendEmail(List<emailAddress> lista, string mensaje)
        {
            throw new NotImplementedException();
        }

        public void writeFile(string nombre, string notificacion)
        {
            throw new NotImplementedException();
        }

        public List<notification> orderNotificationList(List<notification> pList)
        {
            throw new NotImplementedException();
        }
    }
}
