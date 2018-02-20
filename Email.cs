using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication11;

namespace WindowsFormsApplication8

{
    class Email 
    {


        private string eemail;
        private bool envioOK;                 // Define o estado atual de envio do email
        
                 

        MailMessage email = new MailMessage();


     

        public Email(string email)
        {
            InicializeValores();
            eemail = email;

            if (EnviarEmail())
            {
                MessageBox.Show("E-mail enviado com sucesso");
                
            }
            else
                MessageBox.Show("Erro ao enviar o email");
        }

        public void InicializeValores()
        {
            envioOK = false;
           
       }


        public bool EnviarEmail()
        {
            Form2 form = new Form2();

            try
            {
                // Configura o corpo da mensagem a ser enviada
                email.From = new MailAddress("matheus.antunes@e-it.net"); // cria obj com email iformado
                email.To.Add(eemail);
                email.Subject = "Validade do Certificado";
                email.Body = "Olá, seu certificado está prestes a vencer, porfavor renove-o o mais rapido possivel.";

                //Cria o objeto do cliente servidor 
                SmtpClient smtp = new SmtpClient();
                smtp.Host = "smtp.live.com";
                smtp.Port = 25;
                smtp.EnableSsl = true;
                

                // Cria um objeto do servidor com a senha e login informado na classe ConfiguracaoLogin.
                // O objeto usa seu email e sua senha e faz o envio do email através destes dados.
                smtp.Credentials = new System.Net.NetworkCredential("matheus.antunes@e-it.net","M19a05t97e");
                
                
                if (envioOK == true)
                {
                    smtp.Send(email);
                }

                envioOK = true;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ops, ERRO !!! verifique os emails");
                Application.Exit();
                throw new Exception("Erro ao enviar e-mail: " + ex.Message);
            }

            return envioOK;
        }

    }
}

