using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmailService_Classes
{
    class notificationcs
    {
        string mensaje;
        int hora;
        
        void notifications(string pMensaje, int pHora)
        {
            mensaje = pMensaje;
            hora = pHora;
        }
    }
}
