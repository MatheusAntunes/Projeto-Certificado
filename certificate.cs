using System;
using System.Security.Cryptography;
using System.Security.Permissions;
using System.IO;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms;

namespace WindowsFormsApplication11
{
    public class Certificate
    {
        private X509Certificate2 certificado;
        

        public Certificate(string caminho, string senha)
        {            
           certificado =new X509Certificate2(caminho, senha);
        }
         

        public DateTime getDateCertificate()
        {
            //return Convert.ToDateTime(certificado.GetExpirationDateString());
            return Convert.ToDateTime("18/02/2018");
        }
        
               
        public DateTime GetDatePC()
        {
            return Convert.ToDateTime(DateTime.Now.ToLongDateString());
        }

        public string DaysExpire()
        {                               
            return getDateCertificate().Subtract(GetDatePC()).Days.ToString();
        }

        public String SerialNumber()
        {          
           var certificate = new X509Certificate2("C:\\Users\\Matheus Antunes\\Desktop\\certificado\\EIT TECHNOLOGIES CONSULTORIA DE INFORMATICA LTDA12349468000175.pfx", "3-17Tech");
           var serial = certificate.GetSerialNumber();
           return Convert.ToString(serial);
        }
          
    }
}
