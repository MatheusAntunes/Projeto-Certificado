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
        private string emailDestinatario;  // email que receberá a mensagem
        private string assunto;                 // assunto da mensagem 
        private string mensagem;            // mensagem do email

        //Aqui deve ser os dados da sua conta de email
        private string emailAdm;        // Conta de email válida
        private string servidor;           // Servidor da conta de email
        private string senha;              // Define a senha da conta de email valida

        MailMessage email = new MailMessage();


      //  public Email(string email)
      //  {
        //    eemail = email;

       // }

        public Email(string email)
        {
            InicializeValores();
            eemail = email;

            if (EnviarEmail())
            {
                MessageBox.Show("E-mail enviado com sucesso, seu certificado vence em menos de 10 dias.");
                
            }
            else
                MessageBox.Show("Erro ao enviar o email");
        }

        public void InicializeValores()
        {
            envioOK = false;
            emailDestinatario = "matantunes97@gmail.com";
            assunto = "Validade do Certificado";
            mensagem = "Olá, seu certificado está prestes a vencer, porfavor renove-o o mais rapido possivel.";
           //emailAdm = "matheus.antunes@e-it.net";
            servidor = "hotmail.com";
            //senha = "M19a05t97e";

        }


        public bool EnviarEmail()
        {
            Form2 form = new Form2();

            try
            {
                // Configura o corpo da mensagem a ser enviada
                email.From = new MailAddress("matheus.antunes@e-it.net"); // cria obj com email iformado
                email.To.Add(eemail);
                email.Subject = assunto;
                email.Body = mensagem;

                //Cria o objeto do cliente servidor 
                SmtpClient smtp = new SmtpClient();

                if (servidor == "hotmail.com")
                {
                    smtp.Host = "smtp.live.com";
                    smtp.Port = 25;
                    smtp.EnableSsl = true;
                }

                          
             
                if (servidor == "")
                {
                    MessageBox.Show("ERRO, Pf COLOQUE O SERVIDOR DE E-MAIL");
                }

                // Cria um objeto do servidor com a senha e login informado na classe ConfiguracaoLogin.
                // O objeto usa seu email e sua senha e faz o envio do email através destes dados.
                smtp.Credentials = new System.Net.NetworkCredential("matheus.antunes@e-it.net","M19a05t97e");


                envioOK = true;

                if (envioOK == true)
                {
                    smtp.Send(email);

                }
                
                

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ops, ERRO !!! verifique os emails");
                Application.Exit();
                throw new Exception("Erro ao enviar e-mail: " + ex.Message);
            }

            return envioOK;
        }

        [STAThread]
        public void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}

