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
        public X509Certificate2 certificado1;
        

        public Certificate(string caminho, string senha)
        {
                certificado1 = new X509Certificate2(caminho, senha);
            
        }
         
        public DateTime getDateCertificate()
        {
            return Convert.ToDateTime(certificado1.GetExpirationDateString());
            //return Convert.ToDateTime("18/02/2018");
        }
        
               
        public DateTime GetDatePC()
        {
            return Convert.ToDateTime(DateTime.Now.ToLongDateString());
        }

        public string DaysExpire()
        {                               
            return getDateCertificate().Subtract(GetDatePC()).Days.ToString();
        }

        
    }
}
