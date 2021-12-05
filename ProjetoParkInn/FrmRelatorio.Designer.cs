
namespace ProjetoParkInn
{
    partial class FrmRelatorio
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRelatorio));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbTipoRelatorio = new System.Windows.Forms.ComboBox();
            this.btnGerarRelatorio = new System.Windows.Forms.Button();
            this.dtInicial = new System.Windows.Forms.DateTimePicker();
            this.lblDtInicial = new System.Windows.Forms.Label();
            this.lblDtFinal = new System.Windows.Forms.Label();
            this.dtFinal = new System.Windows.Forms.DateTimePicker();
            this.lblNumeroCaixa = new System.Windows.Forms.Label();
            this.txtNumeroCaixa = new System.Windows.Forms.TextBox();
            this.grpreportview = new System.Windows.Forms.GroupBox();
            this.crystalReportViewer = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.CrysRelatorioCaixa = new ProjetoParkInn.CrysRelatorioCaixa();
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.CrysRelatorioCaixaMensal1 = new ProjetoParkInn.CrysRelatorioCaixaMensal();
            this.relatorioGeralBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.relatorioGeral = new ProjetoParkInn.RelatorioGeral();
            this.CrysRelatorioCaixa1 = new ProjetoParkInn.CrysRelatorioCaixa();
            this.grpreportview.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.relatorioGeralBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.relatorioGeral)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(106, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Relatório por:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 22.2F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(550, -3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(185, 45);
            this.label2.TabIndex = 1;
            this.label2.Text = "Relatório";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // cbTipoRelatorio
            // 
            this.cbTipoRelatorio.Font = new System.Drawing.Font("Arial", 16.2F);
            this.cbTipoRelatorio.FormattingEnabled = true;
            this.cbTipoRelatorio.Items.AddRange(new object[] {
            "Caixa",
            "Data"});
            this.cbTipoRelatorio.Location = new System.Drawing.Point(344, 73);
            this.cbTipoRelatorio.Name = "cbTipoRelatorio";
            this.cbTipoRelatorio.Size = new System.Drawing.Size(257, 40);
            this.cbTipoRelatorio.TabIndex = 2;
            this.cbTipoRelatorio.SelectedIndexChanged += new System.EventHandler(this.cbTipoRelatorio_SelectedIndexChanged);
            // 
            // btnGerarRelatorio
            // 
            this.btnGerarRelatorio.BackColor = System.Drawing.Color.Red;
            this.btnGerarRelatorio.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGerarRelatorio.ForeColor = System.Drawing.Color.Snow;
            this.btnGerarRelatorio.Location = new System.Drawing.Point(1028, 173);
            this.btnGerarRelatorio.Name = "btnGerarRelatorio";
            this.btnGerarRelatorio.Size = new System.Drawing.Size(208, 49);
            this.btnGerarRelatorio.TabIndex = 3;
            this.btnGerarRelatorio.Text = "Gerar Relatório";
            this.btnGerarRelatorio.UseVisualStyleBackColor = false;
            this.btnGerarRelatorio.Click += new System.EventHandler(this.btnGerarRelatorio_Click);
            // 
            // dtInicial
            // 
            this.dtInicial.Font = new System.Drawing.Font("Arial", 16.2F);
            this.dtInicial.Location = new System.Drawing.Point(963, 71);
            this.dtInicial.MaxDate = new System.DateTime(2021, 12, 31, 0, 0, 0, 0);
            this.dtInicial.MinDate = new System.DateTime(2021, 1, 1, 0, 0, 0, 0);
            this.dtInicial.Name = "dtInicial";
            this.dtInicial.Size = new System.Drawing.Size(273, 39);
            this.dtInicial.TabIndex = 5;
            this.dtInicial.Visible = false;
            // 
            // lblDtInicial
            // 
            this.lblDtInicial.AutoSize = true;
            this.lblDtInicial.Font = new System.Drawing.Font("Arial Narrow", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDtInicial.ForeColor = System.Drawing.Color.DimGray;
            this.lblDtInicial.Location = new System.Drawing.Point(760, 73);
            this.lblDtInicial.Name = "lblDtInicial";
            this.lblDtInicial.Size = new System.Drawing.Size(144, 33);
            this.lblDtInicial.TabIndex = 6;
            this.lblDtInicial.Text = "Data inicial:";
            this.lblDtInicial.Visible = false;
            // 
            // lblDtFinal
            // 
            this.lblDtFinal.AutoSize = true;
            this.lblDtFinal.Font = new System.Drawing.Font("Arial Narrow", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDtFinal.ForeColor = System.Drawing.Color.DimGray;
            this.lblDtFinal.Location = new System.Drawing.Point(760, 128);
            this.lblDtFinal.Name = "lblDtFinal";
            this.lblDtFinal.Size = new System.Drawing.Size(127, 33);
            this.lblDtFinal.TabIndex = 8;
            this.lblDtFinal.Text = "Data final:";
            this.lblDtFinal.Visible = false;
            // 
            // dtFinal
            // 
            this.dtFinal.Font = new System.Drawing.Font("Arial", 16.2F);
            this.dtFinal.Location = new System.Drawing.Point(963, 122);
            this.dtFinal.MaxDate = new System.DateTime(2021, 12, 31, 0, 0, 0, 0);
            this.dtFinal.MinDate = new System.DateTime(2021, 1, 1, 0, 0, 0, 0);
            this.dtFinal.Name = "dtFinal";
            this.dtFinal.Size = new System.Drawing.Size(273, 39);
            this.dtFinal.TabIndex = 7;
            this.dtFinal.Visible = false;
            // 
            // lblNumeroCaixa
            // 
            this.lblNumeroCaixa.AutoSize = true;
            this.lblNumeroCaixa.Font = new System.Drawing.Font("Arial Narrow", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumeroCaixa.ForeColor = System.Drawing.Color.DimGray;
            this.lblNumeroCaixa.Location = new System.Drawing.Point(106, 128);
            this.lblNumeroCaixa.Name = "lblNumeroCaixa";
            this.lblNumeroCaixa.Size = new System.Drawing.Size(178, 33);
            this.lblNumeroCaixa.TabIndex = 9;
            this.lblNumeroCaixa.Text = "Número Caixa:";
            this.lblNumeroCaixa.Visible = false;
            // 
            // txtNumeroCaixa
            // 
            this.txtNumeroCaixa.Font = new System.Drawing.Font("Arial", 16.2F);
            this.txtNumeroCaixa.Location = new System.Drawing.Point(344, 128);
            this.txtNumeroCaixa.Name = "txtNumeroCaixa";
            this.txtNumeroCaixa.Size = new System.Drawing.Size(257, 39);
            this.txtNumeroCaixa.TabIndex = 10;
            this.txtNumeroCaixa.Visible = false;
            // 
            // grpreportview
            // 
            this.grpreportview.Controls.Add(this.crystalReportViewer);
            this.grpreportview.Controls.Add(this.crystalReportViewer1);
            this.grpreportview.Location = new System.Drawing.Point(5, 247);
            this.grpreportview.Name = "grpreportview";
            this.grpreportview.Size = new System.Drawing.Size(1302, 616);
            this.grpreportview.TabIndex = 11;
            this.grpreportview.TabStop = false;
            // 
            // crystalReportViewer
            // 
            this.crystalReportViewer.ActiveViewIndex = 0;
            this.crystalReportViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer.DisplayStatusBar = false;
            this.crystalReportViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportViewer.Location = new System.Drawing.Point(3, 18);
            this.crystalReportViewer.Name = "crystalReportViewer";
            this.crystalReportViewer.ReportSource = this.CrysRelatorioCaixa;
            this.crystalReportViewer.Size = new System.Drawing.Size(1296, 595);
            this.crystalReportViewer.TabIndex = 0;
            this.crystalReportViewer.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            this.crystalReportViewer.Visible = false;
            // 
            // CrysRelatorioCaixa
            // 
            this.CrysRelatorioCaixa.InitReport += new System.EventHandler(this.CrysRelatorioCaixa_InitReport);
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = 0;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.DisplayStatusBar = false;
            this.crystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportViewer1.Location = new System.Drawing.Point(3, 18);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.ReportSource = this.CrysRelatorioCaixaMensal1;
            this.crystalReportViewer1.Size = new System.Drawing.Size(1296, 595);
            this.crystalReportViewer1.TabIndex = 1;
            this.crystalReportViewer1.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            this.crystalReportViewer1.Visible = false;
            // 
            // relatorioGeralBindingSource
            // 
            this.relatorioGeralBindingSource.DataSource = this.relatorioGeral;
            this.relatorioGeralBindingSource.Position = 0;
            // 
            // relatorioGeral
            // 
            this.relatorioGeral.DataSetName = "RelatorioGeral";
            this.relatorioGeral.EnforceConstraints = false;
            this.relatorioGeral.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Relatorio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(1319, 861);
            this.Controls.Add(this.grpreportview);
            this.Controls.Add(this.txtNumeroCaixa);
            this.Controls.Add(this.lblNumeroCaixa);
            this.Controls.Add(this.lblDtFinal);
            this.Controls.Add(this.dtFinal);
            this.Controls.Add(this.lblDtInicial);
            this.Controls.Add(this.dtInicial);
            this.Controls.Add(this.btnGerarRelatorio);
            this.Controls.Add(this.cbTipoRelatorio);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Relatorio";
            this.Text = "Relatório de Caixa";
            this.grpreportview.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.relatorioGeralBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.relatorioGeral)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbTipoRelatorio;
        private System.Windows.Forms.Button btnGerarRelatorio;
        private System.Windows.Forms.DateTimePicker dtInicial;
        private System.Windows.Forms.Label lblDtInicial;
        private System.Windows.Forms.Label lblDtFinal;
        private System.Windows.Forms.DateTimePicker dtFinal;
        private System.Windows.Forms.Label lblNumeroCaixa;
        private System.Windows.Forms.TextBox txtNumeroCaixa;
        private System.Windows.Forms.GroupBox grpreportview;
        private CrysRelatorioCaixa CrysRelatorioCaixa;
        private CrysRelatorioCaixa CrysRelatorioCaixa1;
        private System.Windows.Forms.BindingSource relatorioGeralBindingSource;
        private RelatorioGeral relatorioGeral;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private CrysRelatorioCaixaMensal CrysRelatorioCaixaMensal1;
    }
}