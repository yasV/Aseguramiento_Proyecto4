using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmailService_Classes;
using Mail4Net;
using Moq;
using NSubstitute;
using System.Net;
using System.IO;

namespace EmailService_Test
{
    [TestFixture]
    public class sendEmail_Test
    {
        [TestCase("yasi1205@hotmail.com")]
        [TestCase("assa2909@gmail.com")]
        [TestCase("nels@gmail.com")]
           
    [Test]
        public void sendCorrectEmail(String email)
        {
            
            var client = new Mail4Net.Client.FakeClient();
            var from = "assa2909@gmail.com";
            var to = email;
            var subject = "Esto es una prueba";
            var body = "Esto es solamente un caso de prueba";

            client.Send(from, to, subject, body);

            bool succesfull = client.MailSent;

            Assert.IsTrue(succesfull);
        }

       
        [TestCase("assa2909@gmail.com","Amanda")]
        [Test]
    public void resendEmail(String email,String name)
        {
            List<emailAddress> resendTest = new List<emailAddress>();
            resendTest.Add(new emailAddress(name, email));
            DateTime hora = DateTime.Now;
            var mockCall = new Mock<servicesInterface>();
            mockCall.Setup(mock => mock.reSendEmail(resendTest, "Esto es una prueba", 1));
            hora.AddHours(2);
            mockCall.Verify(mock => mock.reSendEmail(resendTest, "Esto es una prueba", 2));
            hora.AddHours(2);
            mockCall.Verify(mock => mock.reSendEmail(resendTest, "Esto es una prueba", 3));
            var result = mockCall.Setup(x => x.getintent());
            Assert.LessOrEqual(int.Parse(result), 3);

        }
    public void apiCall()
        {
            var expected = "response content";
            var expectedBytes = Encoding.UTF8.GetBytes(expected);
            var responseStream = new MemoryStream();
            responseStream.Write(expectedBytes, 0, expectedBytes.Length);
            responseStream.Seek(0, SeekOrigin.Begin);

            var response = Substitute.For<HttpWebResponse>();
            response.GetResponseStream().Returns(responseStream);

            var request = Substitute.For<HttpWebRequest>();
            request.GetResponse().Returns(response);

            var factory = Substitute.For<IHttpWebRequestFactory>();
            factory.Create(Arg.Any<string>()).Returns(request);

            //Act
            var actualRequest = factory.Create("http://www.google.com");
            actualRequest.Method = WebRequestMethods.Http.Get;

            string actual;

            using (var httpWebResponse = (HttpWebResponse)actualRequest.GetResponse())
            {
                using (var streamReader = new StreamReader(httpWebResponse.GetResponseStream()))
                {
                    actual = streamReader.ReadToEnd();
                }
            }

            //Assert
            Assert.AreEqual(expected, actual);

        }
    
    
 
    }
}
