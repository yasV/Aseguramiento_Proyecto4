using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmailService_Classes
{
    public interface IFileSystem
    {
        bool OpenFile(string fileName);
        bool writeFile(string nombre, string notificacion);
    }
}
