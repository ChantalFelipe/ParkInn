namespace ProjetoParkInn
{
    partial class FrmTabelaPreco
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
            this.btn_ConfirmaTabela = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_NomeTabela = new System.Windows.Forms.TextBox();
            this.txt_Minuto = new System.Windows.Forms.TextBox();
            this.txt_MinutoA = new System.Windows.Forms.TextBox();
            this.msk_ValorMinuto = new System.Windows.Forms.MaskedTextBox();
            this.msk_ValorMinutoA = new System.Windows.Forms.MaskedTextBox();
            this.grpTabelaPreco = new System.Windows.Forms.GroupBox();
            this.dgvTabelaDePreco = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.clnIdTabela = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnPrimeiraHora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnValorPrimeiraHora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnMinutosAdicional = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnValorAdicional = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnEditar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.clnExcluir = new System.Windows.Forms.DataGridViewButtonColumn();
            this.grpTabelaPreco.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTabelaDePreco)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_ConfirmaTabela
            // 
            this.btn_ConfirmaTabela.BackColor = System.Drawing.Color.Red;
            this.btn_ConfirmaTabela.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ConfirmaTabela.ForeColor = System.Drawing.Color.White;
            this.btn_ConfirmaTabela.Location = new System.Drawing.Point(911, 201);
            this.btn_ConfirmaTabela.Margin = new System.Windows.Forms.Padding(4);
            this.btn_ConfirmaTabela.Name = "btn_ConfirmaTabela";
            this.btn_ConfirmaTabela.Size = new System.Drawing.Size(204, 48);
            this.btn_ConfirmaTabela.TabIndex = 25;
            this.btn_ConfirmaTabela.Text = "CONFIRMAR";
            this.btn_ConfirmaTabela.UseVisualStyleBackColor = false;
            this.btn_ConfirmaTabela.Click += new System.EventHandler(this.btn_ConfirmaTabela_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 22.2F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(464, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(329, 45);
            this.label1.TabIndex = 26;
            this.label1.Text = "Tabela de Preços";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DimGray;
            this.label3.Location = new System.Drawing.Point(31, 93);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(199, 33);
            this.label3.TabIndex = 27;
            this.label3.Text = "Nome da Tabela:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(31, 146);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(231, 33);
            this.label2.TabIndex = 28;
            this.label2.Text = "Primeira(s) Hora(s):";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DimGray;
            this.label4.Location = new System.Drawing.Point(31, 198);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 33);
            this.label4.TabIndex = 29;
            this.label4.Text = "Valor:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DimGray;
            this.label5.Location = new System.Drawing.Point(759, 91);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 33);
            this.label5.TabIndex = 30;
            this.label5.Text = "A cada:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Narrow", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DimGray;
            this.label6.Location = new System.Drawing.Point(759, 144);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 33);
            this.label6.TabIndex = 31;
            this.label6.Text = "Valor:";
            // 
            // txt_NomeTabela
            // 
            this.txt_NomeTabela.Font = new System.Drawing.Font("Arial", 16.2F);
            this.txt_NomeTabela.Location = new System.Drawing.Point(355, 87);
            this.txt_NomeTabela.Margin = new System.Windows.Forms.Padding(4);
            this.txt_NomeTabela.Name = "txt_NomeTabela";
            this.txt_NomeTabela.Size = new System.Drawing.Size(262, 39);
            this.txt_NomeTabela.TabIndex = 32;
            // 
            // txt_Minuto
            // 
            this.txt_Minuto.Font = new System.Drawing.Font("Arial", 16.2F);
            this.txt_Minuto.Location = new System.Drawing.Point(355, 142);
            this.txt_Minuto.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Minuto.Name = "txt_Minuto";
            this.txt_Minuto.Size = new System.Drawing.Size(262, 39);
            this.txt_Minuto.TabIndex = 33;
            // 
            // txt_MinutoA
            // 
            this.txt_MinutoA.Font = new System.Drawing.Font("Arial", 16.2F);
            this.txt_MinutoA.Location = new System.Drawing.Point(908, 81);
            this.txt_MinutoA.Margin = new System.Windows.Forms.Padding(4);
            this.txt_MinutoA.Name = "txt_MinutoA";
            this.txt_MinutoA.Size = new System.Drawing.Size(207, 39);
            this.txt_MinutoA.TabIndex = 35;
            // 
            // msk_ValorMinuto
            // 
            this.msk_ValorMinuto.Font = new System.Drawing.Font("Arial", 16.2F);
            this.msk_ValorMinuto.Location = new System.Drawing.Point(355, 194);
            this.msk_ValorMinuto.Margin = new System.Windows.Forms.Padding(4);
            this.msk_ValorMinuto.Name = "msk_ValorMinuto";
            this.msk_ValorMinuto.Size = new System.Drawing.Size(262, 39);
            this.msk_ValorMinuto.TabIndex = 37;
            // 
            // msk_ValorMinutoA
            // 
            this.msk_ValorMinutoA.Font = new System.Drawing.Font("Arial", 16.2F);
            this.msk_ValorMinutoA.Location = new System.Drawing.Point(908, 140);
            this.msk_ValorMinutoA.Margin = new System.Windows.Forms.Padding(4);
            this.msk_ValorMinutoA.Name = "msk_ValorMinutoA";
            this.msk_ValorMinutoA.Size = new System.Drawing.Size(207, 39);
            this.msk_ValorMinutoA.TabIndex = 38;
            // 
            // grpTabelaPreco
            // 
            this.grpTabelaPreco.Controls.Add(this.dgvTabelaDePreco);
            this.grpTabelaPreco.Location = new System.Drawing.Point(24, 327);
            this.grpTabelaPreco.Name = "grpTabelaPreco";
            this.grpTabelaPreco.Size = new System.Drawing.Size(1270, 511);
            this.grpTabelaPreco.TabIndex = 39;
            this.grpTabelaPreco.TabStop = false;
            // 
            // dgvTabelaDePreco
            // 
            this.dgvTabelaDePreco.AllowUserToAddRows = false;
            this.dgvTabelaDePreco.AllowUserToDeleteRows = false;
            this.dgvTabelaDePreco.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvTabelaDePreco.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvTabelaDePreco.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvTabelaDePreco.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Salmon;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Salmon;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTabelaDePreco.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvTabelaDePreco.ColumnHeadersHeight = 30;
            this.dgvTabelaDePreco.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvTabelaDePreco.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clnIdTabela,
            this.clnNome,
            this.clnPrimeiraHora,
            this.clnValorPrimeiraHora,
            this.clnMinutosAdicional,
            this.clnValorAdicional,
            this.clnEditar,
            this.clnExcluir});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTabelaDePreco.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvTabelaDePreco.EnableHeadersVisualStyles = false;
            this.dgvTabelaDePreco.Location = new System.Drawing.Point(-1, 1);
            this.dgvTabelaDePreco.Margin = new System.Windows.Forms.Padding(4);
            this.dgvTabelaDePreco.Name = "dgvTabelaDePreco";
            this.dgvTabelaDePreco.ReadOnly = true;
            this.dgvTabelaDePreco.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.Snow;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Snow;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTabelaDePreco.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvTabelaDePreco.RowHeadersVisible = false;
            this.dgvTabelaDePreco.RowHeadersWidth = 51;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.Snow;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Snow;
            this.dgvTabelaDePreco.RowsDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvTabelaDePreco.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvTabelaDePreco.Size = new System.Drawing.Size(1270, 508);
            this.dgvTabelaDePreco.TabIndex = 31;
            this.dgvTabelaDePreco.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvClienteCadastrado_CellContentClick);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Narrow", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.DimGray;
            this.label7.Location = new System.Drawing.Point(1134, 91);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(104, 33);
            this.label7.TabIndex = 40;
            this.label7.Text = "minutos";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.DimGray;
            this.label8.Location = new System.Drawing.Point(443, 277);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(298, 32);
            this.label8.TabIndex = 41;
            this.label8.Text = "Tabelas Cadastradas:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(625, 162);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(80, 17);
            this.label9.TabIndex = 42;
            this.label9.Text = "em minutos";
            // 
            // clnIdTabela
            // 
            this.clnIdTabela.DataPropertyName = "ID_TABELA";
            this.clnIdTabela.HeaderText = "ID";
            this.clnIdTabela.MinimumWidth = 6;
            this.clnIdTabela.Name = "clnIdTabela";
            this.clnIdTabela.ReadOnly = true;
            this.clnIdTabela.Width = 45;
            // 
            // clnNome
            // 
            this.clnNome.DataPropertyName = "NM_TABELA";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.clnNome.DefaultCellStyle = dataGridViewCellStyle2;
            this.clnNome.HeaderText = "Nome";
            this.clnNome.MinimumWidth = 6;
            this.clnNome.Name = "clnNome";
            this.clnNome.ReadOnly = true;
            this.clnNome.Width = 125;
            // 
            // clnPrimeiraHora
            // 
            this.clnPrimeiraHora.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.clnPrimeiraHora.DataPropertyName = "CD_MINUTO";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.clnPrimeiraHora.DefaultCellStyle = dataGridViewCellStyle3;
            this.clnPrimeiraHora.HeaderText = "Primeira Hora";
            this.clnPrimeiraHora.MinimumWidth = 6;
            this.clnPrimeiraHora.Name = "clnPrimeiraHora";
            this.clnPrimeiraHora.ReadOnly = true;
            this.clnPrimeiraHora.Width = 144;
            // 
            // clnValorPrimeiraHora
            // 
            this.clnValorPrimeiraHora.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.clnValorPrimeiraHora.DataPropertyName = "CD_VALOR_MINUTO";
            this.clnValorPrimeiraHora.HeaderText = "Valor Primeira Hora";
            this.clnValorPrimeiraHora.MinimumWidth = 6;
            this.clnValorPrimeiraHora.Name = "clnValorPrimeiraHora";
            this.clnValorPrimeiraHora.ReadOnly = true;
            this.clnValorPrimeiraHora.Width = 189;
            // 
            // clnMinutosAdicional
            // 
            this.clnMinutosAdicional.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.clnMinutosAdicional.DataPropertyName = "CD_MINUTO_ADICIONAL";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.clnMinutosAdicional.DefaultCellStyle = dataGridViewCellStyle4;
            this.clnMinutosAdicional.HeaderText = "A cada X Minutos";
            this.clnMinutosAdicional.MinimumWidth = 6;
            this.clnMinutosAdicional.Name = "clnMinutosAdicional";
            this.clnMinutosAdicional.ReadOnly = true;
            this.clnMinutosAdicional.Width = 171;
            // 
            // clnValorAdicional
            // 
            this.clnValorAdicional.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.clnValorAdicional.DataPropertyName = "CD_VALOR_ADICIONAL";
            this.clnValorAdicional.HeaderText = "Valor Adicional";
            this.clnValorAdicional.MinimumWidth = 6;
            this.clnValorAdicional.Name = "clnValorAdicional";
            this.clnValorAdicional.ReadOnly = true;
            this.clnValorAdicional.Width = 151;
            // 
            // clnEditar
            // 
            this.clnEditar.HeaderText = "Editar";
            this.clnEditar.MinimumWidth = 6;
            this.clnEditar.Name = "clnEditar";
            this.clnEditar.ReadOnly = true;
            this.clnEditar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.clnEditar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.clnEditar.Width = 75;
            // 
            // clnExcluir
            // 
            this.clnExcluir.HeaderText = "Excluir";
            this.clnExcluir.MinimumWidth = 6;
            this.clnExcluir.Name = "clnExcluir";
            this.clnExcluir.ReadOnly = true;
            this.clnExcluir.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.clnExcluir.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.clnExcluir.Width = 75;
            // 
            // TabelaPreco
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(1306, 861);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.grpTabelaPreco);
            this.Controls.Add(this.msk_ValorMinutoA);
            this.Controls.Add(this.msk_ValorMinuto);
            this.Controls.Add(this.txt_MinutoA);
            this.Controls.Add(this.txt_Minuto);
            this.Controls.Add(this.txt_NomeTabela);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_ConfirmaTabela);
            this.ForeColor = System.Drawing.Color.DimGray;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "TabelaPreco";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TabelaPreco";
            this.Load += new System.EventHandler(this.TabelaPreco_Load);
            this.grpTabelaPreco.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTabelaDePreco)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_ConfirmaTabela;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_NomeTabela;
        private System.Windows.Forms.TextBox txt_Minuto;
        private System.Windows.Forms.TextBox txt_MinutoA;
        private System.Windows.Forms.MaskedTextBox msk_ValorMinuto;
        private System.Windows.Forms.MaskedTextBox msk_ValorMinutoA;
        private System.Windows.Forms.GroupBox grpTabelaPreco;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dgvTabelaDePreco;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnIdTabela;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnPrimeiraHora;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnValorPrimeiraHora;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnMinutosAdicional;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnValorAdicional;
        private System.Windows.Forms.DataGridViewButtonColumn clnEditar;
        private System.Windows.Forms.DataGridViewButtonColumn clnExcluir;
    }
}