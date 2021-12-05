namespace ProjetoParkInn
{
    partial class FrmCadastroUsuario
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCadastroUsuario));
            this.btn_ConfirmaUsuario = new System.Windows.Forms.Button();
            this.Nome = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_NomeUsuario = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_EmailUsuario = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_SenhaUsuario = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lblTituloUsuario = new System.Windows.Forms.Label();
            this.msk_RGUsuario = new System.Windows.Forms.MaskedTextBox();
            this.msk_CPFUsuario = new System.Windows.Forms.MaskedTextBox();
            this.cb_PermissaoUsuario = new System.Windows.Forms.ComboBox();
            this.grpUsuarioSistema = new System.Windows.Forms.GroupBox();
            this.dgvUsuarioCadastrado = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_SenhaUsuario2 = new System.Windows.Forms.TextBox();
            this.clnNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnCPF = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnRG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnPermissao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnEditar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.clnExcluir = new System.Windows.Forms.DataGridViewButtonColumn();
            this.grpUsuarioSistema.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarioCadastrado)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_ConfirmaUsuario
            // 
            this.btn_ConfirmaUsuario.BackColor = System.Drawing.Color.Red;
            this.btn_ConfirmaUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ConfirmaUsuario.ForeColor = System.Drawing.Color.White;
            this.btn_ConfirmaUsuario.Location = new System.Drawing.Point(1005, 264);
            this.btn_ConfirmaUsuario.Margin = new System.Windows.Forms.Padding(4);
            this.btn_ConfirmaUsuario.Name = "btn_ConfirmaUsuario";
            this.btn_ConfirmaUsuario.Size = new System.Drawing.Size(246, 50);
            this.btn_ConfirmaUsuario.TabIndex = 0;
            this.btn_ConfirmaUsuario.Text = "CADASTRAR";
            this.btn_ConfirmaUsuario.UseVisualStyleBackColor = false;
            this.btn_ConfirmaUsuario.Click += new System.EventHandler(this.btn_ConfirmaUsuario_Click);
            // 
            // Nome
            // 
            this.Nome.AutoSize = true;
            this.Nome.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold);
            this.Nome.ForeColor = System.Drawing.Color.DimGray;
            this.Nome.Location = new System.Drawing.Point(856, 83);
            this.Nome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Nome.Name = "Nome";
            this.Nome.Size = new System.Drawing.Size(85, 35);
            this.Nome.TabIndex = 1;
            this.Nome.Text = "CPF:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(871, 152);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 35);
            this.label1.TabIndex = 3;
            this.label1.Text = "RG:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(764, 217);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(177, 35);
            this.label2.TabIndex = 5;
            this.label2.Text = "Permissão:";
            // 
            // txt_NomeUsuario
            // 
            this.txt_NomeUsuario.Font = new System.Drawing.Font("Arial", 16.2F);
            this.txt_NomeUsuario.Location = new System.Drawing.Point(384, 82);
            this.txt_NomeUsuario.Margin = new System.Windows.Forms.Padding(4);
            this.txt_NomeUsuario.Name = "txt_NomeUsuario";
            this.txt_NomeUsuario.Size = new System.Drawing.Size(325, 39);
            this.txt_NomeUsuario.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.DimGray;
            this.label3.Location = new System.Drawing.Point(228, 83);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 35);
            this.label3.TabIndex = 7;
            this.label3.Text = "Nome:";
            // 
            // txt_EmailUsuario
            // 
            this.txt_EmailUsuario.Font = new System.Drawing.Font("Arial", 16.2F);
            this.txt_EmailUsuario.Location = new System.Drawing.Point(384, 144);
            this.txt_EmailUsuario.Margin = new System.Windows.Forms.Padding(4);
            this.txt_EmailUsuario.Name = "txt_EmailUsuario";
            this.txt_EmailUsuario.Size = new System.Drawing.Size(325, 39);
            this.txt_EmailUsuario.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.DimGray;
            this.label4.Location = new System.Drawing.Point(222, 144);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 35);
            this.label4.TabIndex = 9;
            this.label4.Text = "E-mail:";
            // 
            // txt_SenhaUsuario
            // 
            this.txt_SenhaUsuario.Font = new System.Drawing.Font("Arial", 16.2F);
            this.txt_SenhaUsuario.Location = new System.Drawing.Point(384, 201);
            this.txt_SenhaUsuario.Margin = new System.Windows.Forms.Padding(4);
            this.txt_SenhaUsuario.Name = "txt_SenhaUsuario";
            this.txt_SenhaUsuario.PasswordChar = '*';
            this.txt_SenhaUsuario.Size = new System.Drawing.Size(325, 39);
            this.txt_SenhaUsuario.TabIndex = 12;
            this.txt_SenhaUsuario.TextChanged += new System.EventHandler(this.txt_SenhaUsuario_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.DimGray;
            this.label5.Location = new System.Drawing.Point(221, 202);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 35);
            this.label5.TabIndex = 11;
            this.label5.Text = "Senha:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // lblTituloUsuario
            // 
            this.lblTituloUsuario.AutoSize = true;
            this.lblTituloUsuario.Font = new System.Drawing.Font("Arial", 22.2F, System.Drawing.FontStyle.Bold);
            this.lblTituloUsuario.ForeColor = System.Drawing.Color.DimGray;
            this.lblTituloUsuario.Location = new System.Drawing.Point(443, 19);
            this.lblTituloUsuario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTituloUsuario.Name = "lblTituloUsuario";
            this.lblTituloUsuario.Size = new System.Drawing.Size(418, 45);
            this.lblTituloUsuario.TabIndex = 13;
            this.lblTituloUsuario.Text = "CADASTRO USUÁRIO";
            // 
            // msk_RGUsuario
            // 
            this.msk_RGUsuario.Font = new System.Drawing.Font("Arial", 16.2F);
            this.msk_RGUsuario.Location = new System.Drawing.Point(1005, 151);
            this.msk_RGUsuario.Margin = new System.Windows.Forms.Padding(4);
            this.msk_RGUsuario.Mask = "00,000,000-0";
            this.msk_RGUsuario.Name = "msk_RGUsuario";
            this.msk_RGUsuario.Size = new System.Drawing.Size(246, 39);
            this.msk_RGUsuario.TabIndex = 15;
            // 
            // msk_CPFUsuario
            // 
            this.msk_CPFUsuario.Font = new System.Drawing.Font("Arial", 16.2F);
            this.msk_CPFUsuario.Location = new System.Drawing.Point(1005, 82);
            this.msk_CPFUsuario.Margin = new System.Windows.Forms.Padding(4);
            this.msk_CPFUsuario.Mask = "000,000,000-00";
            this.msk_CPFUsuario.Name = "msk_CPFUsuario";
            this.msk_CPFUsuario.Size = new System.Drawing.Size(246, 39);
            this.msk_CPFUsuario.TabIndex = 16;
            // 
            // cb_PermissaoUsuario
            // 
            this.cb_PermissaoUsuario.Font = new System.Drawing.Font("Arial", 16.2F);
            this.cb_PermissaoUsuario.FormattingEnabled = true;
            this.cb_PermissaoUsuario.Items.AddRange(new object[] {
            "Administrador",
            "Funcionário"});
            this.cb_PermissaoUsuario.Location = new System.Drawing.Point(1005, 216);
            this.cb_PermissaoUsuario.Margin = new System.Windows.Forms.Padding(4);
            this.cb_PermissaoUsuario.Name = "cb_PermissaoUsuario";
            this.cb_PermissaoUsuario.Size = new System.Drawing.Size(246, 40);
            this.cb_PermissaoUsuario.TabIndex = 17;
            // 
            // grpUsuarioSistema
            // 
            this.grpUsuarioSistema.Controls.Add(this.dgvUsuarioCadastrado);
            this.grpUsuarioSistema.Location = new System.Drawing.Point(23, 338);
            this.grpUsuarioSistema.Name = "grpUsuarioSistema";
            this.grpUsuarioSistema.Size = new System.Drawing.Size(1258, 511);
            this.grpUsuarioSistema.TabIndex = 18;
            this.grpUsuarioSistema.TabStop = false;
            // 
            // dgvUsuarioCadastrado
            // 
            this.dgvUsuarioCadastrado.AllowUserToAddRows = false;
            this.dgvUsuarioCadastrado.AllowUserToDeleteRows = false;
            this.dgvUsuarioCadastrado.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvUsuarioCadastrado.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvUsuarioCadastrado.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvUsuarioCadastrado.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Salmon;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Salmon;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvUsuarioCadastrado.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvUsuarioCadastrado.ColumnHeadersHeight = 30;
            this.dgvUsuarioCadastrado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvUsuarioCadastrado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clnNome,
            this.clnEmail,
            this.clnCPF,
            this.clnRG,
            this.clnPermissao,
            this.clnEditar,
            this.clnExcluir});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvUsuarioCadastrado.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvUsuarioCadastrado.EnableHeadersVisualStyles = false;
            this.dgvUsuarioCadastrado.Location = new System.Drawing.Point(-1, 1);
            this.dgvUsuarioCadastrado.Margin = new System.Windows.Forms.Padding(4);
            this.dgvUsuarioCadastrado.Name = "dgvUsuarioCadastrado";
            this.dgvUsuarioCadastrado.ReadOnly = true;
            this.dgvUsuarioCadastrado.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.Snow;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Snow;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvUsuarioCadastrado.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvUsuarioCadastrado.RowHeadersVisible = false;
            this.dgvUsuarioCadastrado.RowHeadersWidth = 51;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.Snow;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Snow;
            this.dgvUsuarioCadastrado.RowsDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvUsuarioCadastrado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvUsuarioCadastrado.Size = new System.Drawing.Size(1260, 508);
            this.dgvUsuarioCadastrado.TabIndex = 31;
            this.dgvUsuarioCadastrado.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvClienteCadastrado_CellContentClick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.DimGray;
            this.label6.Location = new System.Drawing.Point(17, 262);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(281, 35);
            this.label6.TabIndex = 19;
            this.label6.Text = "Senha novamente:";
            // 
            // txt_SenhaUsuario2
            // 
            this.txt_SenhaUsuario2.Font = new System.Drawing.Font("Arial", 16.2F);
            this.txt_SenhaUsuario2.Location = new System.Drawing.Point(384, 262);
            this.txt_SenhaUsuario2.Margin = new System.Windows.Forms.Padding(4);
            this.txt_SenhaUsuario2.Name = "txt_SenhaUsuario2";
            this.txt_SenhaUsuario2.PasswordChar = '*';
            this.txt_SenhaUsuario2.Size = new System.Drawing.Size(325, 39);
            this.txt_SenhaUsuario2.TabIndex = 20;
            // 
            // clnNome
            // 
            this.clnNome.DataPropertyName = "NM_USUARIO";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.clnNome.DefaultCellStyle = dataGridViewCellStyle2;
            this.clnNome.HeaderText = "Nome";
            this.clnNome.MinimumWidth = 6;
            this.clnNome.Name = "clnNome";
            this.clnNome.ReadOnly = true;
            this.clnNome.Width = 220;
            // 
            // clnEmail
            // 
            this.clnEmail.DataPropertyName = "NM_EMAIL";
            this.clnEmail.HeaderText = "Email";
            this.clnEmail.MinimumWidth = 6;
            this.clnEmail.Name = "clnEmail";
            this.clnEmail.ReadOnly = true;
            this.clnEmail.Width = 125;
            // 
            // clnCPF
            // 
            this.clnCPF.DataPropertyName = "ID_CPF";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.clnCPF.DefaultCellStyle = dataGridViewCellStyle3;
            this.clnCPF.HeaderText = "CPF ";
            this.clnCPF.MinimumWidth = 6;
            this.clnCPF.Name = "clnCPF";
            this.clnCPF.ReadOnly = true;
            this.clnCPF.Width = 150;
            // 
            // clnRG
            // 
            this.clnRG.DataPropertyName = "CD_RG";
            this.clnRG.HeaderText = "RG";
            this.clnRG.MinimumWidth = 6;
            this.clnRG.Name = "clnRG";
            this.clnRG.ReadOnly = true;
            this.clnRG.Width = 150;
            // 
            // clnPermissao
            // 
            this.clnPermissao.DataPropertyName = "CD_PERMISSAO";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.clnPermissao.DefaultCellStyle = dataGridViewCellStyle4;
            this.clnPermissao.HeaderText = "Permissão";
            this.clnPermissao.MinimumWidth = 6;
            this.clnPermissao.Name = "clnPermissao";
            this.clnPermissao.ReadOnly = true;
            this.clnPermissao.Width = 140;
            // 
            // clnEditar
            // 
            this.clnEditar.HeaderText = "Editar";
            this.clnEditar.MinimumWidth = 6;
            this.clnEditar.Name = "clnEditar";
            this.clnEditar.ReadOnly = true;
            this.clnEditar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.clnEditar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.clnEditar.Width = 80;
            // 
            // clnExcluir
            // 
            this.clnExcluir.HeaderText = "Excluir";
            this.clnExcluir.MinimumWidth = 6;
            this.clnExcluir.Name = "clnExcluir";
            this.clnExcluir.ReadOnly = true;
            this.clnExcluir.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.clnExcluir.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.clnExcluir.Width = 80;
            // 
            // CadastroUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(1306, 861);
            this.Controls.Add(this.txt_SenhaUsuario2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.grpUsuarioSistema);
            this.Controls.Add(this.cb_PermissaoUsuario);
            this.Controls.Add(this.msk_CPFUsuario);
            this.Controls.Add(this.msk_RGUsuario);
            this.Controls.Add(this.lblTituloUsuario);
            this.Controls.Add(this.txt_SenhaUsuario);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_EmailUsuario);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_NomeUsuario);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Nome);
            this.Controls.Add(this.btn_ConfirmaUsuario);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "CadastroUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastrar Usuario";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpUsuarioSistema.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarioCadastrado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_ConfirmaUsuario;
        private System.Windows.Forms.Label Nome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_NomeUsuario;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_EmailUsuario;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_SenhaUsuario;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblTituloUsuario;
        private System.Windows.Forms.MaskedTextBox msk_RGUsuario;
        private System.Windows.Forms.MaskedTextBox msk_CPFUsuario;
        private System.Windows.Forms.ComboBox cb_PermissaoUsuario;
        private System.Windows.Forms.GroupBox grpUsuarioSistema;
        private System.Windows.Forms.DataGridView dgvUsuarioCadastrado;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_SenhaUsuario2;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnCPF;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnRG;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnPermissao;
        private System.Windows.Forms.DataGridViewButtonColumn clnEditar;
        private System.Windows.Forms.DataGridViewButtonColumn clnExcluir;
    }
}