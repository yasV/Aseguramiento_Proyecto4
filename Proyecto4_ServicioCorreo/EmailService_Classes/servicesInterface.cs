using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmailService_Classes
{
    interface servicesInterface
    {
        bool sendEmail(List<emailAdress>, string mensaje); //enviar Email
        void reSendEmail(List<emailAdress>, string mensaje, int numIntentos); //reenviar email
        void createNotificationDaily(string hora, string mensaje); //crear notificacion diaria
        void createNotificationMonthly(int dia ,string hora, string mensaje); 
        void createNotificationWeekly(int dia, string hora, string mensaje);
        void executeNotification();
        void writeFile(string nombre, string notoficacion);
    }
}
