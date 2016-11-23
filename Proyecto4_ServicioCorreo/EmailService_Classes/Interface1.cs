using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace EmailService_Classes
{
    public interface IHttpWebRequestFactory
    {
        HttpWebRequest Create(string uri);
    }
}
