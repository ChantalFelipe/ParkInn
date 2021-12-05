namespace ProjetoParkInn
{
    partial class FrmLoginParkInn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLoginParkInn));
            this.label2 = new System.Windows.Forms.Label();
            this.txt_LoginUsuario = new System.Windows.Forms.TextBox();
            this.txt_SenhaUsuario = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_ConfirmaLogin = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnlRecuperarSenha = new System.Windows.Forms.Panel();
            this.btnRecuperarSenha = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtEmailRecuperado = new System.Windows.Forms.TextBox();
            this.lblVoltar = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlRecuperarSenha.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(79, 268);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 29);
            this.label2.TabIndex = 18;
            this.label2.Text = "Senha:";
            // 
            // txt_LoginUsuario
            // 
            this.txt_LoginUsuario.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_LoginUsuario.Location = new System.Drawing.Point(224, 210);
            this.txt_LoginUsuario.Margin = new System.Windows.Forms.Padding(4);
            this.txt_LoginUsuario.Name = "txt_LoginUsuario";
            this.txt_LoginUsuario.Size = new System.Drawing.Size(240, 34);
            this.txt_LoginUsuario.TabIndex = 19;
            this.txt_LoginUsuario.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txt_SenhaUsuario
            // 
            this.txt_SenhaUsuario.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_SenhaUsuario.Location = new System.Drawing.Point(224, 263);
            this.txt_SenhaUsuario.Margin = new System.Windows.Forms.Padding(4);
            this.txt_SenhaUsuario.Name = "txt_SenhaUsuario";
            this.txt_SenhaUsuario.PasswordChar = '*';
            this.txt_SenhaUsuario.Size = new System.Drawing.Size(240, 34);
            this.txt_SenhaUsuario.TabIndex = 20;
            this.txt_SenhaUsuario.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_SenhaUsuario_KeyUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(79, 215);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 29);
            this.label1.TabIndex = 21;
            this.label1.Text = "Usuário:";
            // 
            // btn_ConfirmaLogin
            // 
            this.btn_ConfirmaLogin.BackColor = System.Drawing.Color.Red;
            this.btn_ConfirmaLogin.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ConfirmaLogin.ForeColor = System.Drawing.Color.White;
            this.btn_ConfirmaLogin.Location = new System.Drawing.Point(224, 308);
            this.btn_ConfirmaLogin.Margin = new System.Windows.Forms.Padding(4);
            this.btn_ConfirmaLogin.Name = "btn_ConfirmaLogin";
            this.btn_ConfirmaLogin.Size = new System.Drawing.Size(240, 44);
            this.btn_ConfirmaLogin.TabIndex = 22;
            this.btn_ConfirmaLogin.Text = "ENTRAR";
            this.btn_ConfirmaLogin.UseVisualStyleBackColor = false;
            this.btn_ConfirmaLogin.Click += new System.EventHandler(this.btn_ConfirmaLogin_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label3.Location = new System.Drawing.Point(315, 356);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 17);
            this.label3.TabIndex = 23;
            this.label3.Text = "Esqueceu sua senha?";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(250, 13);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(240, 215);
            this.pictureBox1.TabIndex = 24;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pnlRecuperarSenha
            // 
            this.pnlRecuperarSenha.Controls.Add(this.label5);
            this.pnlRecuperarSenha.Controls.Add(this.lblVoltar);
            this.pnlRecuperarSenha.Controls.Add(this.btnRecuperarSenha);
            this.pnlRecuperarSenha.Controls.Add(this.txtEmailRecuperado);
            this.pnlRecuperarSenha.Controls.Add(this.label4);
            this.pnlRecuperarSenha.Controls.Add(this.pictureBox2);
            this.pnlRecuperarSenha.Location = new System.Drawing.Point(-7, -1);
            this.pnlRecuperarSenha.Name = "pnlRecuperarSenha";
            this.pnlRecuperarSenha.Size = new System.Drawing.Size(640, 427);
            this.pnlRecuperarSenha.TabIndex = 25;
            this.pnlRecuperarSenha.Visible = false;
            // 
            // btnRecuperarSenha
            // 
            this.btnRecuperarSenha.BackColor = System.Drawing.Color.Red;
            this.btnRecuperarSenha.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRecuperarSenha.ForeColor = System.Drawing.Color.White;
            this.btnRecuperarSenha.Location = new System.Drawing.Point(267, 318);
            this.btnRecuperarSenha.Margin = new System.Windows.Forms.Padding(4);
            this.btnRecuperarSenha.Name = "btnRecuperarSenha";
            this.btnRecuperarSenha.Size = new System.Drawing.Size(240, 44);
            this.btnRecuperarSenha.TabIndex = 30;
            this.btnRecuperarSenha.Text = "ENVIAR";
            this.btnRecuperarSenha.UseVisualStyleBackColor = false;
            this.btnRecuperarSenha.Click += new System.EventHandler(this.btnRecuperarSenha_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DimGray;
            this.label4.Location = new System.Drawing.Point(82, 268);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 29);
            this.label4.TabIndex = 29;
            this.label4.Text = "Email:";
            // 
            // txtEmailRecuperado
            // 
            this.txtEmailRecuperado.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmailRecuperado.Location = new System.Drawing.Point(183, 265);
            this.txtEmailRecuperado.Margin = new System.Windows.Forms.Padding(4);
            this.txtEmailRecuperado.Name = "txtEmailRecuperado";
            this.txtEmailRecuperado.Size = new System.Drawing.Size(324, 30);
            this.txtEmailRecuperado.TabIndex = 27;
            // 
            // lblVoltar
            // 
            this.lblVoltar.AutoSize = true;
            this.lblVoltar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblVoltar.Location = new System.Drawing.Point(15, 399);
            this.lblVoltar.Name = "lblVoltar";
            this.lblVoltar.Size = new System.Drawing.Size(45, 17);
            this.lblVoltar.TabIndex = 31;
            this.lblVoltar.Text = "Voltar";
            this.lblVoltar.Click += new System.EventHandler(this.lblVoltar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DimGray;
            this.label5.Location = new System.Drawing.Point(224, 18);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(220, 35);
            this.label5.TabIndex = 32;
            this.label5.Text = "Recuperar Senha";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(252, 71);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(240, 215);
            this.pictureBox2.TabIndex = 26;
            this.pictureBox2.TabStop = false;
            // 
            // LoginParkInn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(631, 422);
            this.Controls.Add(this.pnlRecuperarSenha);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_ConfirmaLogin);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_SenhaUsuario);
            this.Controls.Add(this.txt_LoginUsuario);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.ForeColor = System.Drawing.Color.DimGray;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "LoginParkInn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.LoginParkInn_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlRecuperarSenha.ResumeLayout(false);
            this.pnlRecuperarSenha.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_LoginUsuario;
        private System.Windows.Forms.TextBox txt_SenhaUsuario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_ConfirmaLogin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel pnlRecuperarSenha;
        private System.Windows.Forms.Button btnRecuperarSenha;
        private System.Windows.Forms.TextBox txtEmailRecuperado;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblVoltar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}