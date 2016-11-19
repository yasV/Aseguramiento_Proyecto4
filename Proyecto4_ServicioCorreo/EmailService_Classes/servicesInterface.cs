using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmailService_Classes
{
    interface servicesInterface
    {
        bool sendEmail(List<emailAddress> emailList, string mensaje); //enviar Email
        void reSendEmail(List<emailAddress> emailList, string mensaje, int numIntentos); //reenviar email
        void createNotificationDaily(string hora, string mensaje); //crear notificacion diaria, y llama la funcion writefle
        void createNotificationMonthly(int dia ,string hora, string mensaje); 
        void createNotificationWeekly(int dia, string hora, string mensaje);
        void executeNotification(); // lee archivo, crea lista, ordena y revista
        void writeFile(string nombre, string notoficacion); // escribe en el archivo
    }
}
