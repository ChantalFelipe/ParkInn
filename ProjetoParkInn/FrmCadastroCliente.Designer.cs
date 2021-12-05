namespace ProjetoParkInn
{
    partial class FrmCadastroCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCadastroCliente));
            this.lblcadastrocliente = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNomeCliente = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_ConfirmaCliente = new System.Windows.Forms.Button();
            this.msk_DataNasc = new System.Windows.Forms.MaskedTextBox();
            this.msk_CPF = new System.Windows.Forms.MaskedTextBox();
            this.msk_RG = new System.Windows.Forms.MaskedTextBox();
            this.grpCadastroCliente = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvClienteCadastrado = new System.Windows.Forms.DataGridView();
            this.clnNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnCPF = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnRG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnNascimento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnEditar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.clnExcluir = new System.Windows.Forms.DataGridViewButtonColumn();
            this.grpCadastroCliente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClienteCadastrado)).BeginInit();
            this.SuspendLayout();
            // 
            // lblcadastrocliente
            // 
            this.lblcadastrocliente.AutoSize = true;
            this.lblcadastrocliente.Font = new System.Drawing.Font("Arial", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcadastrocliente.ForeColor = System.Drawing.Color.DimGray;
            this.lblcadastrocliente.Location = new System.Drawing.Point(377, 19);
            this.lblcadastrocliente.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblcadastrocliente.Name = "lblcadastrocliente";
            this.lblcadastrocliente.Size = new System.Drawing.Size(429, 45);
            this.lblcadastrocliente.TabIndex = 0;
            this.lblcadastrocliente.Text = "CADASTRAR CLIENTE";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(84, 110);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 35);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nome:";
            // 
            // txtNomeCliente
            // 
            this.txtNomeCliente.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeCliente.Location = new System.Drawing.Point(223, 107);
            this.txtNomeCliente.Margin = new System.Windows.Forms.Padding(4);
            this.txtNomeCliente.Name = "txtNomeCliente";
            this.txtNomeCliente.Size = new System.Drawing.Size(391, 39);
            this.txtNomeCliente.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.DimGray;
            this.label3.Location = new System.Drawing.Point(84, 171);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(195, 35);
            this.label3.TabIndex = 3;
            this.label3.Text = "Nascimento:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.DimGray;
            this.label4.Location = new System.Drawing.Point(808, 110);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 35);
            this.label4.TabIndex = 5;
            this.label4.Text = "CPF:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.DimGray;
            this.label5.Location = new System.Drawing.Point(808, 171);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 35);
            this.label5.TabIndex = 7;
            this.label5.Text = "RG:";
            // 
            // btn_ConfirmaCliente
            // 
            this.btn_ConfirmaCliente.BackColor = System.Drawing.Color.Red;
            this.btn_ConfirmaCliente.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold);
            this.btn_ConfirmaCliente.ForeColor = System.Drawing.Color.White;
            this.btn_ConfirmaCliente.Location = new System.Drawing.Point(981, 217);
            this.btn_ConfirmaCliente.Margin = new System.Windows.Forms.Padding(4);
            this.btn_ConfirmaCliente.Name = "btn_ConfirmaCliente";
            this.btn_ConfirmaCliente.Size = new System.Drawing.Size(222, 48);
            this.btn_ConfirmaCliente.TabIndex = 9;
            this.btn_ConfirmaCliente.Text = "CONFIRMAR";
            this.btn_ConfirmaCliente.UseVisualStyleBackColor = false;
            this.btn_ConfirmaCliente.Click += new System.EventHandler(this.btn_ConfirmaCliente_Click);
            // 
            // msk_DataNasc
            // 
            this.msk_DataNasc.Font = new System.Drawing.Font("Arial", 16.2F);
            this.msk_DataNasc.Location = new System.Drawing.Point(353, 168);
            this.msk_DataNasc.Margin = new System.Windows.Forms.Padding(4);
            this.msk_DataNasc.Mask = "00/00/0000";
            this.msk_DataNasc.Name = "msk_DataNasc";
            this.msk_DataNasc.Size = new System.Drawing.Size(261, 39);
            this.msk_DataNasc.TabIndex = 19;
            this.msk_DataNasc.ValidatingType = typeof(System.DateTime);
            // 
            // msk_CPF
            // 
            this.msk_CPF.Font = new System.Drawing.Font("Arial", 16.2F);
            this.msk_CPF.Location = new System.Drawing.Point(926, 107);
            this.msk_CPF.Margin = new System.Windows.Forms.Padding(4);
            this.msk_CPF.Mask = "000,000,000-00";
            this.msk_CPF.Name = "msk_CPF";
            this.msk_CPF.Size = new System.Drawing.Size(277, 39);
            this.msk_CPF.TabIndex = 20;
            // 
            // msk_RG
            // 
            this.msk_RG.Font = new System.Drawing.Font("Arial", 16.2F);
            this.msk_RG.Location = new System.Drawing.Point(926, 168);
            this.msk_RG.Margin = new System.Windows.Forms.Padding(4);
            this.msk_RG.Mask = "00,000,000-0";
            this.msk_RG.Name = "msk_RG";
            this.msk_RG.Size = new System.Drawing.Size(277, 39);
            this.msk_RG.TabIndex = 21;
            // 
            // grpCadastroCliente
            // 
            this.grpCadastroCliente.Controls.Add(this.dgvClienteCadastrado);
            this.grpCadastroCliente.Location = new System.Drawing.Point(36, 338);
            this.grpCadastroCliente.Name = "grpCadastroCliente";
            this.grpCadastroCliente.Size = new System.Drawing.Size(1258, 511);
            this.grpCadastroCliente.TabIndex = 25;
            this.grpCadastroCliente.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(417, 291);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(372, 32);
            this.label1.TabIndex = 26;
            this.label1.Text = "CLIENTES CADASTRADOS";
            // 
            // dgvClienteCadastrado
            // 
            this.dgvClienteCadastrado.AllowUserToAddRows = false;
            this.dgvClienteCadastrado.AllowUserToDeleteRows = false;
            this.dgvClienteCadastrado.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvClienteCadastrado.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvClienteCadastrado.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvClienteCadastrado.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Salmon;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Salmon;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvClienteCadastrado.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvClienteCadastrado.ColumnHeadersHeight = 30;
            this.dgvClienteCadastrado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvClienteCadastrado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clnNome,
            this.clnCPF,
            this.clnRG,
            this.clnNascimento,
            this.clnEditar,
            this.clnExcluir});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvClienteCadastrado.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvClienteCadastrado.EnableHeadersVisualStyles = false;
            this.dgvClienteCadastrado.Location = new System.Drawing.Point(-3, 0);
            this.dgvClienteCadastrado.Margin = new System.Windows.Forms.Padding(4);
            this.dgvClienteCadastrado.Name = "dgvClienteCadastrado";
            this.dgvClienteCadastrado.ReadOnly = true;
            this.dgvClienteCadastrado.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.Snow;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Snow;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvClienteCadastrado.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvClienteCadastrado.RowHeadersVisible = false;
            this.dgvClienteCadastrado.RowHeadersWidth = 51;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.Snow;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Snow;
            this.dgvClienteCadastrado.RowsDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvClienteCadastrado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvClienteCadastrado.Size = new System.Drawing.Size(1260, 508);
            this.dgvClienteCadastrado.TabIndex = 30;
            this.dgvClienteCadastrado.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvClienteCadastrado_CellContentClick);
            // 
            // clnNome
            // 
            this.clnNome.DataPropertyName = "NM_CLIENTE";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.clnNome.DefaultCellStyle = dataGridViewCellStyle2;
            this.clnNome.HeaderText = "Nome";
            this.clnNome.MinimumWidth = 6;
            this.clnNome.Name = "clnNome";
            this.clnNome.ReadOnly = true;
            this.clnNome.Width = 220;
            // 
            // clnCPF
            // 
            this.clnCPF.DataPropertyName = "CPF_CLIENTE";
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
            this.clnRG.DataPropertyName = "RG_CLIENTE";
            this.clnRG.HeaderText = "RG";
            this.clnRG.MinimumWidth = 6;
            this.clnRG.Name = "clnRG";
            this.clnRG.ReadOnly = true;
            this.clnRG.Width = 150;
            // 
            // clnNascimento
            // 
            this.clnNascimento.DataPropertyName = "DT_NASCIMENTO";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.clnNascimento.DefaultCellStyle = dataGridViewCellStyle4;
            this.clnNascimento.HeaderText = "Nascimento";
            this.clnNascimento.MinimumWidth = 6;
            this.clnNascimento.Name = "clnNascimento";
            this.clnNascimento.ReadOnly = true;
            this.clnNascimento.Width = 225;
            // 
            // clnEditar
            // 
            this.clnEditar.HeaderText = "Editar";
            this.clnEditar.MinimumWidth = 6;
            this.clnEditar.Name = "clnEditar";
            this.clnEditar.ReadOnly = true;
            this.clnEditar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.clnEditar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // clnExcluir
            // 
            this.clnExcluir.HeaderText = "Excluir";
            this.clnExcluir.MinimumWidth = 6;
            this.clnExcluir.Name = "clnExcluir";
            this.clnExcluir.ReadOnly = true;
            this.clnExcluir.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.clnExcluir.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // CadastroCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(1306, 861);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grpCadastroCliente);
            this.Controls.Add(this.msk_RG);
            this.Controls.Add(this.msk_CPF);
            this.Controls.Add(this.msk_DataNasc);
            this.Controls.Add(this.btn_ConfirmaCliente);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNomeCliente);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblcadastrocliente);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "CadastroCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastrar Cliente";
            this.Load += new System.EventHandler(this.CadastroCliente_Load);
            this.grpCadastroCliente.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvClienteCadastrado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblcadastrocliente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNomeCliente;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_ConfirmaCliente;
        private System.Windows.Forms.MaskedTextBox msk_DataNasc;
        private System.Windows.Forms.MaskedTextBox msk_CPF;
        private System.Windows.Forms.MaskedTextBox msk_RG;
        private System.Windows.Forms.GroupBox grpCadastroCliente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvClienteCadastrado;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnCPF;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnRG;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnNascimento;
        private System.Windows.Forms.DataGridViewButtonColumn clnEditar;
        private System.Windows.Forms.DataGridViewButtonColumn clnExcluir;
    }
}