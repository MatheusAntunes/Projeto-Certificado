namespace WindowsFormsApplication11
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.bttEnviar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.DateNow = new System.Windows.Forms.TextBox();
            this.DateCertificate = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.DayExp = new System.Windows.Forms.TextBox();
            this.txtCaminho = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.btt_Search = new System.Windows.Forms.Button();
            this.bttSair = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bttEnviar
            // 
            this.bttEnviar.Location = new System.Drawing.Point(105, 298);
            this.bttEnviar.Name = "bttEnviar";
            this.bttEnviar.Size = new System.Drawing.Size(75, 23);
            this.bttEnviar.TabIndex = 0;
            this.bttEnviar.Text = "VERIFICAR";
            this.bttEnviar.UseVisualStyleBackColor = true;
            this.bttEnviar.Click += new System.EventHandler(this.bttEnviar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Data de vencimento do Certificado";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 178);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Data de hoje";
            // 
            // DateNow
            // 
            this.DateNow.Location = new System.Drawing.Point(12, 194);
            this.DateNow.Name = "DateNow";
            this.DateNow.Size = new System.Drawing.Size(114, 20);
            this.DateNow.TabIndex = 4;
            this.DateNow.TextChanged += new System.EventHandler(this.DateNow_TextChanged);
            // 
            // DateCertificate
            // 
            this.DateCertificate.Location = new System.Drawing.Point(12, 133);
            this.DateCertificate.Name = "DateCertificate";
            this.DateCertificate.Size = new System.Drawing.Size(114, 20);
            this.DateCertificate.TabIndex = 5;
            this.DateCertificate.TextChanged += new System.EventHandler(this.DateCertificate_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 230);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Dias para expirar";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // DayExp
            // 
            this.DayExp.Location = new System.Drawing.Point(12, 246);
            this.DayExp.Name = "DayExp";
            this.DayExp.Size = new System.Drawing.Size(114, 20);
            this.DayExp.TabIndex = 7;
            this.DayExp.TextChanged += new System.EventHandler(this.DayExp_TextChanged);
            // 
            // txtCaminho
            // 
            this.txtCaminho.Location = new System.Drawing.Point(12, 25);
            this.txtCaminho.Name = "txtCaminho";
            this.txtCaminho.Size = new System.Drawing.Size(246, 20);
            this.txtCaminho.TabIndex = 9;
            this.txtCaminho.TextChanged += new System.EventHandler(this.txtCaminho_TextChanged );
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Caminho :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 61);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Senha";
            // 
            // txtSenha
            // 
            this.txtSenha.Location = new System.Drawing.Point(12, 77);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(114, 20);
            this.txtSenha.TabIndex = 11;
            this.txtSenha.UseSystemPasswordChar = true;
            this.txtSenha.Validating += new System.ComponentModel.CancelEventHandler(this.txtSenha_LostFocus);
            // 
            // btt_Search
            // 
            this.btt_Search.Location = new System.Drawing.Point(273, 24);
            this.btt_Search.Name = "btt_Search";
            this.btt_Search.Size = new System.Drawing.Size(39, 21);
            this.btt_Search.TabIndex = 12;
            this.btt_Search.Text = "...";
            this.btt_Search.UseVisualStyleBackColor = true;
            this.btt_Search.Click += new System.EventHandler(this.btt_Search_Click);
            // 
            // bttSair
            // 
            this.bttSair.Location = new System.Drawing.Point(221, 298);
            this.bttSair.Name = "bttSair";
            this.bttSair.Size = new System.Drawing.Size(75, 23);
            this.bttSair.TabIndex = 13;
            this.bttSair.Text = "SAIR";
            this.bttSair.UseVisualStyleBackColor = true;
            this.bttSair.Click += new System.EventHandler(this.bttSair_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 352);
            this.Controls.Add(this.bttSair);
            this.Controls.Add(this.btt_Search);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtCaminho);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.DayExp);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.DateCertificate);
            this.Controls.Add(this.DateNow);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bttEnviar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bttEnviar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox DateNow;
        private System.Windows.Forms.TextBox DateCertificate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox DayExp;
        private System.Windows.Forms.TextBox txtCaminho;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.Button btt_Search;
        private System.Windows.Forms.Button bttSair;
    }
}

