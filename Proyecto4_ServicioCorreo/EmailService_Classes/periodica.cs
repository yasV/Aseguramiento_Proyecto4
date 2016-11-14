using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmailService_Classes
{
    class periodica: notificaciones
    {
        String tipo;
        List<String> dias;
        TimeSpan hora;
    }
}
