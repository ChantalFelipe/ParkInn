using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports;
using CrystalDecisions.ReportSource;
using System.Web.Services;
using CrystalDecisions.CrystalReports.Engine;

namespace ProjetoParkInn
{
    public partial class FrmRelatorio : Form
    {
        SqlConnection cn = new SqlConnection(conexao.StringConexao());

        string strSQL;
        public FrmRelatorio()
        {
            InitializeComponent();
        }

        private void CrysRelatorioCaixa_InitReport(object sender, System.EventArgs e)
        {

        }

        private void btnGerarRelatorio_Click(object sender, System.EventArgs e)
        {

            if (cbTipoRelatorio.SelectedIndex == 0)
            {
                if (string.IsNullOrWhiteSpace(txtNumeroCaixa.Text))
                {
                    MessageBox.Show("Digite um número de caixa!");

                }
                else
                {
                    cn.Close();
                    try
                    {
                        strSQL = "SELECT * FROM MOVIMENTO WHERE DT_SAIDA IS NOT NULL AND MOV_NR_CAIXA =" + Convert.ToInt32(txtNumeroCaixa.Text);
                        cn.Open();
                        SqlDataAdapter adapter = new SqlDataAdapter(strSQL, cn);
                        RelatorioGeral ds = new RelatorioGeral();
                        adapter.Fill(ds, "MOVIMENTO");
                        DataTable dt = new DataTable();
                        dt = ds.Tables["MOVIMENTO"];
                        if (dt.Rows.Count > 0)
                        {
                            CrysRelatorioCaixa cr = new CrysRelatorioCaixa();
                            cr.SetDataSource(ds.Tables["MOVIMENTO"]);//especifica o DataTable criado 
                            crystalReportViewer.ReportSource = cr;
                            crystalReportViewer.Refresh();
                            crystalReportViewer.Visible = true;
                            crystalReportViewer1.Visible = false;
                            cn.Close();
                        }
                        else
                        {
                            cn.Close();
                            MessageBox.Show("O caixa não foi encontrado, por favor utilize a consulta por datas para indentificar o caixa certo!");
                        }
                    }
                  
                    catch (Exception EX)
                {
                    cn.Close();
                    MessageBox.Show("Não foi possível consultar as informações no banco, por favor contate o suporte!" + EX.ToString());
                }
            }
                }
                else if (cbTipoRelatorio.SelectedIndex == 1)
                {
                    cn.Close();
                    try
                    {
                        strSQL = "SELECT * FROM CAIXA WHERE DT_FINAL IS NOT NULL AND DT_FINAL BETWEEN '" + DateTime.Parse(dtInicial.Text)  +  "' AND '" + DateTime.Parse(dtFinal.Text) + "'";
                        cn.Open();
                        SqlDataAdapter adapter = new SqlDataAdapter(strSQL, cn);
                        RelatorioGeral ds = new RelatorioGeral();
                        adapter.Fill(ds, "CAIXA");
                        DataTable dt = new DataTable();
                        dt = ds.Tables["CAIXA"];
                        if (dt.Rows.Count > 0)
                        {
                            CrysRelatorioCaixaMensal cr = new CrysRelatorioCaixaMensal();
                            cr.SetDataSource(ds.Tables["CAIXA"]);//especifica o DataTable criado 
                            crystalReportViewer1.ReportSource = cr;
                            crystalReportViewer1.Refresh();
                            crystalReportViewer1.Visible = true;
                            crystalReportViewer.Visible = false;
                            cn.Close();
                            txtNumeroCaixa.Text = "";
                        }
                        else
                        {
                            cn.Close();
                            MessageBox.Show("Não foi encontrado nenhum caixa no período informado, por favor utilize altere a consulta por datas para indentificar os caixas certos!");
                        }
                    }
                    catch (Exception EX)
                    {
                        cn.Close();
                        MessageBox.Show("Não foi possível consultar as informações no banco, por favor contate o suporte!" + EX.ToString());
                    }

                }
                cn.Close();
            }
        


        private void cbTipoRelatorio_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbTipoRelatorio.SelectedIndex == 0)
            {
                txtNumeroCaixa.Visible = true;
                dtFinal.Visible = false;
                dtInicial.Visible = false;
                lblDtFinal.Visible = false;
                lblDtInicial.Visible = false;
                lblNumeroCaixa.Visible = true;

            }
            else if(cbTipoRelatorio.SelectedIndex == 1)
            {
                txtNumeroCaixa.Visible = false;
                dtFinal.Visible = true;
                dtInicial.Visible = true;
                lblDtFinal.Visible = true;
                lblDtInicial.Visible = true;
                lblNumeroCaixa.Visible = false;
            }
            else
            {
                txtNumeroCaixa.Visible = false;
                dtFinal.Visible = false;
                dtInicial.Visible = false;
                txtNumeroCaixa.Text = "";
                lblNumeroCaixa.Visible = false;
                lblDtInicial.Visible = false;
                lblDtFinal.Visible = false;
            }
        }
    }
}
