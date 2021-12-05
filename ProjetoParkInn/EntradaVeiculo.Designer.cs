namespace ProjetoParkInn
{
    partial class EntradaVeiculo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EntradaVeiculo));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_PlacaVeiculo = new System.Windows.Forms.TextBox();
            this.txt_ModeloVeiculo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_ConfirmaEntrada = new System.Windows.Forms.Button();
            this.lblEntradaSucesso = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 22.2F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(82, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(381, 45);
            this.label1.TabIndex = 17;
            this.label1.Text = "Entrada de Veículos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(54, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 35);
            this.label2.TabIndex = 18;
            this.label2.Text = "Placa:";
            // 
            // txt_PlacaVeiculo
            // 
            this.txt_PlacaVeiculo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_PlacaVeiculo.Font = new System.Drawing.Font("Arial", 16.2F);
            this.txt_PlacaVeiculo.Location = new System.Drawing.Point(190, 113);
            this.txt_PlacaVeiculo.MaxLength = 7;
            this.txt_PlacaVeiculo.Name = "txt_PlacaVeiculo";
            this.txt_PlacaVeiculo.Size = new System.Drawing.Size(197, 39);
            this.txt_PlacaVeiculo.TabIndex = 19;
            // 
            // txt_ModeloVeiculo
            // 
            this.txt_ModeloVeiculo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_ModeloVeiculo.Font = new System.Drawing.Font("Arial", 16.2F);
            this.txt_ModeloVeiculo.Location = new System.Drawing.Point(190, 176);
            this.txt_ModeloVeiculo.Name = "txt_ModeloVeiculo";
            this.txt_ModeloVeiculo.Size = new System.Drawing.Size(197, 39);
            this.txt_ModeloVeiculo.TabIndex = 23;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.DimGray;
            this.label4.Location = new System.Drawing.Point(29, 177);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 35);
            this.label4.TabIndex = 22;
            this.label4.Text = "Modelo:";
            // 
            // btn_ConfirmaEntrada
            // 
            this.btn_ConfirmaEntrada.BackColor = System.Drawing.Color.Red;
            this.btn_ConfirmaEntrada.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ConfirmaEntrada.ForeColor = System.Drawing.Color.White;
            this.btn_ConfirmaEntrada.Location = new System.Drawing.Point(190, 221);
            this.btn_ConfirmaEntrada.Name = "btn_ConfirmaEntrada";
            this.btn_ConfirmaEntrada.Size = new System.Drawing.Size(197, 45);
            this.btn_ConfirmaEntrada.TabIndex = 24;
            this.btn_ConfirmaEntrada.Text = "ENTRAR";
            this.btn_ConfirmaEntrada.UseVisualStyleBackColor = false;
            this.btn_ConfirmaEntrada.Click += new System.EventHandler(this.btn_ConfirmaEntrada_Click);
            // 
            // lblEntradaSucesso
            // 
            this.lblEntradaSucesso.AutoSize = true;
            this.lblEntradaSucesso.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEntradaSucesso.ForeColor = System.Drawing.Color.DarkSeaGreen;
            this.lblEntradaSucesso.Location = new System.Drawing.Point(56, 276);
            this.lblEntradaSucesso.Name = "lblEntradaSucesso";
            this.lblEntradaSucesso.Size = new System.Drawing.Size(0, 24);
            this.lblEntradaSucesso.TabIndex = 25;
            this.lblEntradaSucesso.Visible = false;
            // 
            // EntradaVeiculo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(510, 352);
            this.Controls.Add(this.lblEntradaSucesso);
            this.Controls.Add(this.btn_ConfirmaEntrada);
            this.Controls.Add(this.txt_ModeloVeiculo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_PlacaVeiculo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.DimGray;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EntradaVeiculo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Entrada de Veículos";
            this.Load += new System.EventHandler(this.EntradaCarro_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_PlacaVeiculo;
        private System.Windows.Forms.TextBox txt_ModeloVeiculo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_ConfirmaEntrada;
        private System.Windows.Forms.Label lblEntradaSucesso;
    }
}