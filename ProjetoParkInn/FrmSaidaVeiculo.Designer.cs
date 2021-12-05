namespace ProjetoParkInn
{
    partial class FrmSaidaVeiculo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSaidaVeiculo));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_PlacaVeiculo = new System.Windows.Forms.TextBox();
            this.txt_ModeloVeiculo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_Minutos = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_PesquisaVeiculo = new System.Windows.Forms.Button();
            this.btnReceber = new System.Windows.Forms.Button();
            this.msk_dtEntrada = new System.Windows.Forms.MaskedTextBox();
            this.txt_ValorPagar = new System.Windows.Forms.TextBox();
            this.cmbTabelaPreco = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnDebito = new FontAwesome.Sharp.IconButton();
            this.btnCredito = new FontAwesome.Sharp.IconButton();
            this.btnDinheiro = new FontAwesome.Sharp.IconButton();
            this.btnPix = new FontAwesome.Sharp.IconButton();
            this.txtFormaPagamento = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblCPFCliente = new System.Windows.Forms.Label();
            this.msk_CPFCliente = new System.Windows.Forms.MaskedTextBox();
            this.txtTicket = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(561, 37);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 46);
            this.label1.TabIndex = 31;
            this.label1.Text = "Saída";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(31, 149);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 35);
            this.label2.TabIndex = 32;
            this.label2.Text = "Placa:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txt_PlacaVeiculo
            // 
            this.txt_PlacaVeiculo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_PlacaVeiculo.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_PlacaVeiculo.Location = new System.Drawing.Point(165, 146);
            this.txt_PlacaVeiculo.Margin = new System.Windows.Forms.Padding(4);
            this.txt_PlacaVeiculo.MaxLength = 7;
            this.txt_PlacaVeiculo.Name = "txt_PlacaVeiculo";
            this.txt_PlacaVeiculo.Size = new System.Drawing.Size(188, 42);
            this.txt_PlacaVeiculo.TabIndex = 33;
            // 
            // txt_ModeloVeiculo
            // 
            this.txt_ModeloVeiculo.Enabled = false;
            this.txt_ModeloVeiculo.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ModeloVeiculo.Location = new System.Drawing.Point(202, 417);
            this.txt_ModeloVeiculo.Margin = new System.Windows.Forms.Padding(4);
            this.txt_ModeloVeiculo.Name = "txt_ModeloVeiculo";
            this.txt_ModeloVeiculo.Size = new System.Drawing.Size(485, 42);
            this.txt_ModeloVeiculo.TabIndex = 35;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DimGray;
            this.label3.Location = new System.Drawing.Point(27, 417);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 35);
            this.label3.TabIndex = 34;
            this.label3.Text = "Modelo:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DimGray;
            this.label4.Location = new System.Drawing.Point(27, 488);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(251, 35);
            this.label4.TabIndex = 36;
            this.label4.Text = "Data de entrada:";
            // 
            // txt_Minutos
            // 
            this.txt_Minutos.Enabled = false;
            this.txt_Minutos.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Minutos.Location = new System.Drawing.Point(357, 560);
            this.txt_Minutos.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Minutos.Name = "txt_Minutos";
            this.txt_Minutos.Size = new System.Drawing.Size(330, 42);
            this.txt_Minutos.TabIndex = 39;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DimGray;
            this.label5.Location = new System.Drawing.Point(31, 560);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(212, 35);
            this.label5.TabIndex = 38;
            this.label5.Text = "Permanência:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DimGray;
            this.label6.Location = new System.Drawing.Point(31, 633);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(213, 35);
            this.label6.TabIndex = 40;
            this.label6.Text = "Valor a pagar:";
            // 
            // btn_PesquisaVeiculo
            // 
            this.btn_PesquisaVeiculo.BackColor = System.Drawing.Color.Red;
            this.btn_PesquisaVeiculo.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_PesquisaVeiculo.ForeColor = System.Drawing.Color.White;
            this.btn_PesquisaVeiculo.Location = new System.Drawing.Point(1019, 218);
            this.btn_PesquisaVeiculo.Margin = new System.Windows.Forms.Padding(4);
            this.btn_PesquisaVeiculo.Name = "btn_PesquisaVeiculo";
            this.btn_PesquisaVeiculo.Size = new System.Drawing.Size(237, 57);
            this.btn_PesquisaVeiculo.TabIndex = 42;
            this.btn_PesquisaVeiculo.Text = "PESQUISAR";
            this.btn_PesquisaVeiculo.UseVisualStyleBackColor = false;
            this.btn_PesquisaVeiculo.Click += new System.EventHandler(this.btn_PesquisaVeiculo_Click);
            // 
            // btnReceber
            // 
            this.btnReceber.BackColor = System.Drawing.Color.Red;
            this.btnReceber.Enabled = false;
            this.btnReceber.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReceber.ForeColor = System.Drawing.Color.White;
            this.btnReceber.Location = new System.Drawing.Point(367, 774);
            this.btnReceber.Margin = new System.Windows.Forms.Padding(4);
            this.btnReceber.Name = "btnReceber";
            this.btnReceber.Size = new System.Drawing.Size(320, 52);
            this.btnReceber.TabIndex = 43;
            this.btnReceber.Text = "RECEBER VALOR";
            this.btnReceber.UseVisualStyleBackColor = false;
            this.btnReceber.Click += new System.EventHandler(this.btn_SaidaVeiculo_Click);
            // 
            // msk_dtEntrada
            // 
            this.msk_dtEntrada.Enabled = false;
            this.msk_dtEntrada.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msk_dtEntrada.Location = new System.Drawing.Point(357, 488);
            this.msk_dtEntrada.Margin = new System.Windows.Forms.Padding(4);
            this.msk_dtEntrada.Name = "msk_dtEntrada";
            this.msk_dtEntrada.Size = new System.Drawing.Size(330, 42);
            this.msk_dtEntrada.TabIndex = 44;
            // 
            // txt_ValorPagar
            // 
            this.txt_ValorPagar.Enabled = false;
            this.txt_ValorPagar.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ValorPagar.Location = new System.Drawing.Point(357, 633);
            this.txt_ValorPagar.Margin = new System.Windows.Forms.Padding(4);
            this.txt_ValorPagar.Name = "txt_ValorPagar";
            this.txt_ValorPagar.Size = new System.Drawing.Size(330, 42);
            this.txt_ValorPagar.TabIndex = 45;
            // 
            // cmbTabelaPreco
            // 
            this.cmbTabelaPreco.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTabelaPreco.FormattingEnabled = true;
            this.cmbTabelaPreco.Location = new System.Drawing.Point(922, 146);
            this.cmbTabelaPreco.Name = "cmbTabelaPreco";
            this.cmbTabelaPreco.Size = new System.Drawing.Size(334, 43);
            this.cmbTabelaPreco.TabIndex = 46;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.DimGray;
            this.label7.Location = new System.Drawing.Point(583, 146);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(251, 35);
            this.label7.TabIndex = 47;
            this.label7.Text = "Tabela de preço:";
            // 
            // btnDebito
            // 
            this.btnDebito.BackColor = System.Drawing.Color.DarkGray;
            this.btnDebito.Enabled = false;
            this.btnDebito.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDebito.IconChar = FontAwesome.Sharp.IconChar.CcMastercard;
            this.btnDebito.IconColor = System.Drawing.Color.Black;
            this.btnDebito.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDebito.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDebito.Location = new System.Drawing.Point(845, 420);
            this.btnDebito.Name = "btnDebito";
            this.btnDebito.Size = new System.Drawing.Size(411, 75);
            this.btnDebito.TabIndex = 48;
            this.btnDebito.Text = "Débito";
            this.btnDebito.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDebito.UseVisualStyleBackColor = true;
            this.btnDebito.Click += new System.EventHandler(this.btnDebito_Click);
            // 
            // btnCredito
            // 
            this.btnCredito.BackColor = System.Drawing.Color.DarkGray;
            this.btnCredito.Enabled = false;
            this.btnCredito.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCredito.IconChar = FontAwesome.Sharp.IconChar.MoneyCheckAlt;
            this.btnCredito.IconColor = System.Drawing.Color.Black;
            this.btnCredito.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCredito.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCredito.Location = new System.Drawing.Point(845, 514);
            this.btnCredito.Name = "btnCredito";
            this.btnCredito.Size = new System.Drawing.Size(411, 75);
            this.btnCredito.TabIndex = 49;
            this.btnCredito.Text = "Crédito";
            this.btnCredito.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCredito.UseVisualStyleBackColor = true;
            this.btnCredito.Click += new System.EventHandler(this.btnCredito_Click);
            // 
            // btnDinheiro
            // 
            this.btnDinheiro.BackColor = System.Drawing.Color.DarkGray;
            this.btnDinheiro.Enabled = false;
            this.btnDinheiro.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDinheiro.IconChar = FontAwesome.Sharp.IconChar.MoneyBillAlt;
            this.btnDinheiro.IconColor = System.Drawing.Color.Black;
            this.btnDinheiro.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDinheiro.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDinheiro.Location = new System.Drawing.Point(845, 611);
            this.btnDinheiro.Name = "btnDinheiro";
            this.btnDinheiro.Size = new System.Drawing.Size(411, 75);
            this.btnDinheiro.TabIndex = 50;
            this.btnDinheiro.Text = "Dinheiro";
            this.btnDinheiro.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDinheiro.UseVisualStyleBackColor = true;
            this.btnDinheiro.Click += new System.EventHandler(this.btnDinheiro_Click);
            // 
            // btnPix
            // 
            this.btnPix.BackColor = System.Drawing.Color.DarkGray;
            this.btnPix.Enabled = false;
            this.btnPix.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPix.IconChar = FontAwesome.Sharp.IconChar.Qrcode;
            this.btnPix.IconColor = System.Drawing.Color.Black;
            this.btnPix.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnPix.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPix.Location = new System.Drawing.Point(845, 711);
            this.btnPix.Name = "btnPix";
            this.btnPix.Size = new System.Drawing.Size(411, 75);
            this.btnPix.TabIndex = 51;
            this.btnPix.Text = "Pix";
            this.btnPix.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPix.UseVisualStyleBackColor = true;
            this.btnPix.Click += new System.EventHandler(this.btnPix_Click);
            // 
            // txtFormaPagamento
            // 
            this.txtFormaPagamento.Enabled = false;
            this.txtFormaPagamento.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFormaPagamento.Location = new System.Drawing.Point(465, 703);
            this.txtFormaPagamento.Margin = new System.Windows.Forms.Padding(4);
            this.txtFormaPagamento.Name = "txtFormaPagamento";
            this.txtFormaPagamento.Size = new System.Drawing.Size(222, 42);
            this.txtFormaPagamento.TabIndex = 53;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.DimGray;
            this.label8.Location = new System.Drawing.Point(31, 703);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(326, 35);
            this.label8.TabIndex = 52;
            this.label8.Text = "Forma de pagamento:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.DimGray;
            this.label9.Location = new System.Drawing.Point(839, 360);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(328, 33);
            this.label9.TabIndex = 54;
            this.label9.Text = "Formas de Pagamento:";
            // 
            // lblCPFCliente
            // 
            this.lblCPFCliente.AutoSize = true;
            this.lblCPFCliente.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCPFCliente.ForeColor = System.Drawing.Color.DimGray;
            this.lblCPFCliente.Location = new System.Drawing.Point(31, 215);
            this.lblCPFCliente.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCPFCliente.Name = "lblCPFCliente";
            this.lblCPFCliente.Size = new System.Drawing.Size(193, 35);
            this.lblCPFCliente.TabIndex = 55;
            this.lblCPFCliente.Text = "CPF Cliente:";
            this.lblCPFCliente.Visible = false;
            // 
            // msk_CPFCliente
            // 
            this.msk_CPFCliente.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msk_CPFCliente.Location = new System.Drawing.Point(297, 215);
            this.msk_CPFCliente.Margin = new System.Windows.Forms.Padding(4);
            this.msk_CPFCliente.Mask = "000,000,000-00";
            this.msk_CPFCliente.Name = "msk_CPFCliente";
            this.msk_CPFCliente.Size = new System.Drawing.Size(290, 42);
            this.msk_CPFCliente.TabIndex = 57;
            this.msk_CPFCliente.Visible = false;
            // 
            // txtTicket
            // 
            this.txtTicket.Enabled = false;
            this.txtTicket.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTicket.Location = new System.Drawing.Point(202, 354);
            this.txtTicket.Margin = new System.Windows.Forms.Padding(4);
            this.txtTicket.MaxLength = 7;
            this.txtTicket.Name = "txtTicket";
            this.txtTicket.ReadOnly = true;
            this.txtTicket.Size = new System.Drawing.Size(485, 42);
            this.txtTicket.TabIndex = 59;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.DimGray;
            this.label10.Location = new System.Drawing.Point(27, 354);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(111, 35);
            this.label10.TabIndex = 58;
            this.label10.Text = "Ticket:";
            // 
            // SaidaVeiculo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(1306, 861);
            this.Controls.Add(this.txtTicket);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.msk_CPFCliente);
            this.Controls.Add(this.lblCPFCliente);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtFormaPagamento);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnPix);
            this.Controls.Add(this.btnDinheiro);
            this.Controls.Add(this.btnCredito);
            this.Controls.Add(this.btnDebito);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cmbTabelaPreco);
            this.Controls.Add(this.txt_ValorPagar);
            this.Controls.Add(this.msk_dtEntrada);
            this.Controls.Add(this.btnReceber);
            this.Controls.Add(this.btn_PesquisaVeiculo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_Minutos);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_ModeloVeiculo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_PlacaVeiculo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "SaidaVeiculo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Saída";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_PlacaVeiculo;
        private System.Windows.Forms.TextBox txt_ModeloVeiculo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_Minutos;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_PesquisaVeiculo;
        private System.Windows.Forms.Button btnReceber;
        private System.Windows.Forms.MaskedTextBox msk_dtEntrada;
        private System.Windows.Forms.TextBox txt_ValorPagar;
        private System.Windows.Forms.ComboBox cmbTabelaPreco;
        private System.Windows.Forms.Label label7;
        private FontAwesome.Sharp.IconButton btnDebito;
        private FontAwesome.Sharp.IconButton btnCredito;
        private FontAwesome.Sharp.IconButton btnDinheiro;
        private FontAwesome.Sharp.IconButton btnPix;
        private System.Windows.Forms.TextBox txtFormaPagamento;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblCPFCliente;
        private System.Windows.Forms.MaskedTextBox msk_CPFCliente;
        private System.Windows.Forms.TextBox txtTicket;
        private System.Windows.Forms.Label label10;
    }
}