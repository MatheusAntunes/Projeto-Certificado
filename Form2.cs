using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication8;

namespace WindowsFormsApplication11
{
    public partial class Form2 : Form
    {
        string x;
        public Form2()
        {
            InitializeComponent();
         }

       public void txtEmail_TextChanged(object sender, EventArgs e)
        {
          
        }

       

        private void bttEnviar_Click(object sender, EventArgs e)
        {
            Email email = new Email(txtEmail.Text);
            email.EnviarEmail();
            Application.Exit();
        }
    }
}
