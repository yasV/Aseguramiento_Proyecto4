﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmailService_Classes
{
    public interface servicesInterface
    {
        bool sendEmail(emailAddress emailList, string mensaje); //enviar Email
        void reSendEmail(List<emailAddress> emailList, string mensaje, int numIntentos); //reenviar email
        void createNotificationDaily(string hora, string mensaje); //crear notificacion diaria, y llama la funcion writefle
        void createNotificationMonthly(int dia ,string hora, string mensaje); 
        void createNotificationWeekly(int dia, string hora, string mensaje);
        void executeNotification(); //revisa la lista y ejecuta
        List<notification> orderNotificationList(List<notification> pList);
        void writeFile(string nombre, string notoficacion); // escribe en el archivo
        int getintent();
    }
}
