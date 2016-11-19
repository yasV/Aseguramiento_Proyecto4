using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmailService_Classes
{
    public class notification
    {
        public string mensaje;
        public int hora;
        
        public notification(string pMensaje, int pHora)
        {
            mensaje = pMensaje;
            hora = pHora;
        }
    }
}
