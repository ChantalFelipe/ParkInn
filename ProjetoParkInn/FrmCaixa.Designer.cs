
namespace ProjetoParkInn
{
    partial class FrmCaixa
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvCaixa = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.txtQtdTransacao = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtValorFaturado = new System.Windows.Forms.TextBox();
            this.btnFecharCaixa = new System.Windows.Forms.Button();
            this.clnPlaca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnModelo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnDataEntrada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnDataSaida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnValorPagar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCaixa)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(606, 19);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 46);
            this.label1.TabIndex = 31;
            this.label1.Text = "Caixa";
            // 
            // dgvCaixa
            // 
            this.dgvCaixa.AllowUserToAddRows = false;
            this.dgvCaixa.AllowUserToDeleteRows = false;
            this.dgvCaixa.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvCaixa.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvCaixa.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvCaixa.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Salmon;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Salmon;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCaixa.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCaixa.ColumnHeadersHeight = 30;
            this.dgvCaixa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvCaixa.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clnPlaca,
            this.clnModelo,
            this.clnDataEntrada,
            this.clnDataSaida,
            this.clnValorPagar});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCaixa.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvCaixa.EnableHeadersVisualStyles = false;
            this.dgvCaixa.Location = new System.Drawing.Point(87, 93);
            this.dgvCaixa.Margin = new System.Windows.Forms.Padding(4);
            this.dgvCaixa.Name = "dgvCaixa";
            this.dgvCaixa.ReadOnly = true;
            this.dgvCaixa.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Snow;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Snow;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCaixa.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvCaixa.RowHeadersVisible = false;
            this.dgvCaixa.RowHeadersWidth = 51;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Snow;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Snow;
            this.dgvCaixa.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvCaixa.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvCaixa.Size = new System.Drawing.Size(1204, 631);
            this.dgvCaixa.TabIndex = 32;
            this.dgvCaixa.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCaixa_CellContentClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DimGray;
            this.label4.Location = new System.Drawing.Point(82, 804);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(240, 29);
            this.label4.TabIndex = 47;
            this.label4.Text = "Valor total faturado:";
            // 
            // txtQtdTransacao
            // 
            this.txtQtdTransacao.Enabled = false;
            this.txtQtdTransacao.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQtdTransacao.Location = new System.Drawing.Point(523, 749);
            this.txtQtdTransacao.Margin = new System.Windows.Forms.Padding(4);
            this.txtQtdTransacao.Name = "txtQtdTransacao";
            this.txtQtdTransacao.Size = new System.Drawing.Size(188, 34);
            this.txtQtdTransacao.TabIndex = 46;
            this.txtQtdTransacao.TextChanged += new System.EventHandler(this.txtQtdTransacao_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DimGray;
            this.label3.Location = new System.Drawing.Point(82, 754);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(319, 29);
            this.label3.TabIndex = 45;
            this.label3.Text = "Quantidade de transações:";
            // 
            // txtValorFaturado
            // 
            this.txtValorFaturado.Enabled = false;
            this.txtValorFaturado.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValorFaturado.Location = new System.Drawing.Point(523, 799);
            this.txtValorFaturado.Margin = new System.Windows.Forms.Padding(4);
            this.txtValorFaturado.Name = "txtValorFaturado";
            this.txtValorFaturado.Size = new System.Drawing.Size(188, 34);
            this.txtValorFaturado.TabIndex = 48;
            // 
            // btnFecharCaixa
            // 
            this.btnFecharCaixa.BackColor = System.Drawing.Color.Red;
            this.btnFecharCaixa.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFecharCaixa.ForeColor = System.Drawing.Color.White;
            this.btnFecharCaixa.Location = new System.Drawing.Point(1051, 793);
            this.btnFecharCaixa.Margin = new System.Windows.Forms.Padding(4);
            this.btnFecharCaixa.Name = "btnFecharCaixa";
            this.btnFecharCaixa.Size = new System.Drawing.Size(240, 45);
            this.btnFecharCaixa.TabIndex = 49;
            this.btnFecharCaixa.Text = "FECHAR CAIXA";
            this.btnFecharCaixa.UseVisualStyleBackColor = false;
            this.btnFecharCaixa.Click += new System.EventHandler(this.btnFecharCaixa_Click);
            // 
            // clnPlaca
            // 
            this.clnPlaca.DataPropertyName = "CD_PLACA";
            this.clnPlaca.FillWeight = 150F;
            this.clnPlaca.HeaderText = "Placa";
            this.clnPlaca.MinimumWidth = 6;
            this.clnPlaca.Name = "clnPlaca";
            this.clnPlaca.ReadOnly = true;
            this.clnPlaca.Width = 140;
            // 
            // clnModelo
            // 
            this.clnModelo.DataPropertyName = "NM_VEICULO";
            this.clnModelo.HeaderText = "Modelo";
            this.clnModelo.MinimumWidth = 6;
            this.clnModelo.Name = "clnModelo";
            this.clnModelo.ReadOnly = true;
            this.clnModelo.Width = 150;
            // 
            // clnDataEntrada
            // 
            this.clnDataEntrada.DataPropertyName = "DT_ENTRADA";
            this.clnDataEntrada.FillWeight = 150F;
            this.clnDataEntrada.HeaderText = "Data Entrada";
            this.clnDataEntrada.MinimumWidth = 6;
            this.clnDataEntrada.Name = "clnDataEntrada";
            this.clnDataEntrada.ReadOnly = true;
            this.clnDataEntrada.Width = 210;
            // 
            // clnDataSaida
            // 
            this.clnDataSaida.DataPropertyName = "DT_SAIDA";
            this.clnDataSaida.FillWeight = 150F;
            this.clnDataSaida.HeaderText = "Data Saida";
            this.clnDataSaida.MinimumWidth = 6;
            this.clnDataSaida.Name = "clnDataSaida";
            this.clnDataSaida.ReadOnly = true;
            this.clnDataSaida.Width = 210;
            // 
            // clnValorPagar
            // 
            this.clnValorPagar.DataPropertyName = "CD_VALOR_PAGAR";
            this.clnValorPagar.FillWeight = 120F;
            this.clnValorPagar.HeaderText = "Valor Pago";
            this.clnValorPagar.MinimumWidth = 6;
            this.clnValorPagar.Name = "clnValorPagar";
            this.clnValorPagar.ReadOnly = true;
            this.clnValorPagar.Width = 170;
            // 
            // FrmCaixa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(1306, 861);
            this.Controls.Add(this.btnFecharCaixa);
            this.Controls.Add(this.txtValorFaturado);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtQtdTransacao);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgvCaixa);
            this.Controls.Add(this.label1);
            this.Name = "FrmCaixa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmCaixa";
            this.Load += new System.EventHandler(this.FrmCaixa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCaixa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvCaixa;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtQtdTransacao;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtValorFaturado;
        private System.Windows.Forms.Button btnFecharCaixa;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnPlaca;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnModelo;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnDataEntrada;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnDataSaida;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnValorPagar;
    }
}