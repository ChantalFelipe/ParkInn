namespace ProjetoParkInn
{
    partial class FrmPatioVeiculos
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
            this.label1 = new System.Windows.Forms.Label();
            this.dgv_PatioVeiculos = new System.Windows.Forms.DataGridView();
            this.clnPlaca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnModelo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnTicket = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnDataEntrada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnSaida = new System.Windows.Forms.DataGridViewButtonColumn();
            this.clnRemover = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_PatioVeiculos)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(582, 42);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 46);
            this.label1.TabIndex = 30;
            this.label1.Text = "Pátio";
            // 
            // dgv_PatioVeiculos
            // 
            this.dgv_PatioVeiculos.AllowUserToAddRows = false;
            this.dgv_PatioVeiculos.AllowUserToDeleteRows = false;
            this.dgv_PatioVeiculos.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgv_PatioVeiculos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_PatioVeiculos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_PatioVeiculos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Salmon;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Salmon;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_PatioVeiculos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_PatioVeiculos.ColumnHeadersHeight = 30;
            this.dgv_PatioVeiculos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgv_PatioVeiculos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clnPlaca,
            this.clnModelo,
            this.clnTicket,
            this.clnDataEntrada,
            this.clnSaida,
            this.clnRemover});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_PatioVeiculos.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgv_PatioVeiculos.EnableHeadersVisualStyles = false;
            this.dgv_PatioVeiculos.Location = new System.Drawing.Point(67, 115);
            this.dgv_PatioVeiculos.Margin = new System.Windows.Forms.Padding(4);
            this.dgv_PatioVeiculos.Name = "dgv_PatioVeiculos";
            this.dgv_PatioVeiculos.ReadOnly = true;
            this.dgv_PatioVeiculos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.Snow;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Snow;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_PatioVeiculos.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgv_PatioVeiculos.RowHeadersVisible = false;
            this.dgv_PatioVeiculos.RowHeadersWidth = 51;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.Snow;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Snow;
            this.dgv_PatioVeiculos.RowsDefaultCellStyle = dataGridViewCellStyle7;
            this.dgv_PatioVeiculos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgv_PatioVeiculos.Size = new System.Drawing.Size(1204, 715);
            this.dgv_PatioVeiculos.TabIndex = 29;
            this.dgv_PatioVeiculos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_PatioVeiculos_CellContentClick);
            // 
            // clnPlaca
            // 
            this.clnPlaca.DataPropertyName = "CD_PLACA";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.clnPlaca.DefaultCellStyle = dataGridViewCellStyle2;
            this.clnPlaca.HeaderText = "Placa";
            this.clnPlaca.MinimumWidth = 6;
            this.clnPlaca.Name = "clnPlaca";
            this.clnPlaca.ReadOnly = true;
            this.clnPlaca.Width = 155;
            // 
            // clnModelo
            // 
            this.clnModelo.DataPropertyName = "NM_VEICULO";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.clnModelo.DefaultCellStyle = dataGridViewCellStyle3;
            this.clnModelo.HeaderText = "Modelo";
            this.clnModelo.MinimumWidth = 6;
            this.clnModelo.Name = "clnModelo";
            this.clnModelo.ReadOnly = true;
            this.clnModelo.Width = 170;
            // 
            // clnTicket
            // 
            this.clnTicket.DataPropertyName = "MOV_NR_TICKET";
            this.clnTicket.HeaderText = "Ticket";
            this.clnTicket.MinimumWidth = 6;
            this.clnTicket.Name = "clnTicket";
            this.clnTicket.ReadOnly = true;
            this.clnTicket.Width = 150;
            // 
            // clnDataEntrada
            // 
            this.clnDataEntrada.DataPropertyName = "DT_ENTRADA";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.clnDataEntrada.DefaultCellStyle = dataGridViewCellStyle4;
            this.clnDataEntrada.HeaderText = "Data Entrada";
            this.clnDataEntrada.MinimumWidth = 6;
            this.clnDataEntrada.Name = "clnDataEntrada";
            this.clnDataEntrada.ReadOnly = true;
            this.clnDataEntrada.Width = 225;
            // 
            // clnSaida
            // 
            this.clnSaida.HeaderText = "Saida";
            this.clnSaida.MinimumWidth = 6;
            this.clnSaida.Name = "clnSaida";
            this.clnSaida.ReadOnly = true;
            this.clnSaida.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.clnSaida.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // clnRemover
            // 
            this.clnRemover.HeaderText = "Remover";
            this.clnRemover.MinimumWidth = 6;
            this.clnRemover.Name = "clnRemover";
            this.clnRemover.ReadOnly = true;
            this.clnRemover.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.clnRemover.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // PatioVeiculos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(1306, 861);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgv_PatioVeiculos);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "PatioVeiculos";
            this.Text = "PatioVeiculos";
            this.Load += new System.EventHandler(this.PatioVeiculos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_PatioVeiculos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv_PatioVeiculos;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnPlaca;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnModelo;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnTicket;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnDataEntrada;
        private System.Windows.Forms.DataGridViewButtonColumn clnSaida;
        private System.Windows.Forms.DataGridViewButtonColumn clnRemover;
    }
}