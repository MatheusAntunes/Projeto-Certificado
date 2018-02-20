using System;
using System.Windows.Forms;
using System.Security.Cryptography.X509Certificates;


namespace WindowsFormsApplication11
{
    public partial class Form1 : Form
    {
        public string nome { get; set; }
        public string caminho { get; set; }

        public Form1()
        {
            InitializeComponent();
        }

        internal string GetType(object text)
        {
            throw new NotImplementedException();
        }
        
        private void bttEnviar_Click(object sender, EventArgs e)
        {

            if (!string.IsNullOrEmpty(txtCaminho.Text) && !string.IsNullOrEmpty(txtSenha.Text))
            {

                Certificate certificate = new Certificate(txtCaminho.Text, txtSenha.Text);

                DateCertificate.Text = Convert.ToString(certificate.getDateCertificate());
                DateNow.Text = Convert.ToString(certificate.GetDatePC());
                DayExp.Text = Convert.ToString(certificate.DaysExpire());

                //Condições para o disparo de e-mail.

                if (Convert.ToInt16(certificate.DaysExpire()) <= 10)
                {

                    Form2 tela = new Form2();
                    tela.Show();

                }
                else
                {
                    MessageBox.Show("ATENÇÃO !!! Seu certificado vence em : " + certificate.DaysExpire() + "dias.");
                    Application.Exit();
                }


            }else
            {
                MessageBox.Show("Verifique se os campo Caminho e Senha estão preeenchidos");
                
            }


            
                
                
        }

        private void DateNow_TextChanged(object sender, EventArgs e)
        {

        }

        private void DateCertificate_TextChanged(object sender, EventArgs e)
        {

        }

        private void DayExp_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSeriallNumb_TextChanged(object sender, EventArgs e)
        {
           
        }

       public void txtCaminho_TextChanged(object sender, EventArgs e)
        {
        
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtSenha_LostFocus(object sender, System.ComponentModel.CancelEventArgs e)
        {


            if (!string.IsNullOrEmpty(txtSenha.Text)) 
            {
                
                try 
                {
                    
                    var certificado1 = new X509Certificate2(txtCaminho.Text, txtSenha.Text);

                }
                catch
                {

                    MessageBox.Show("Senha invalida digite novamente");
                    txtSenha.Clear();


                }


            }

        }



        private void btt_Search_Click(object sender, EventArgs e)
        {
            
            OpenFileDialog open = new OpenFileDialog();
            open.InitialDirectory = "c: \\";
            open.Filter = "arquivos txt (* .txt) | * .txt | Todos os arquivos (*. *) | *. *";
            open.FilterIndex = 2;
            open.RestoreDirectory = true;


            

            if( open.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    txtCaminho.Text = open.FileName;
                                        
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
                }

            }




        }

        private void bttSair_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}