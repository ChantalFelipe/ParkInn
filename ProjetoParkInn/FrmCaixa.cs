using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ProjetoParkInn
{
    public partial class FrmCaixa : Form
    {
        SqlConnection cn = new SqlConnection(conexao.StringConexao());
        SqlCommand comando;
        double ValorTotal = 0;
        int contador = 0;

        public FrmCaixa()
        {
            InitializeComponent();
        }

        private void FrmCaixa_Load(object sender, EventArgs e)
        {
            //Colocar Try


            cn.Open();
            string strSQL = "select  CD_PLACA, NM_VEICULO, DT_ENTRADA, DT_SAIDA, CD_VALOR_PAGAR FROM MOVIMENTO WHERE MOV_NR_CAIXA =" + Convert.ToInt32(Caixa.caixaAberto) + " AND CD_VALOR_PAGAR IS NOT NULL";
            comando = new SqlCommand(strSQL, cn);
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = comando;
            DataTable table = new DataTable();
            adapter.Fill(table);
            dgvCaixa.DataSource = table;
            cn.Close();
            dgvCaixa.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;



            //Aqui vai pegar os valores da tabela para apresentar o total de quantidade de transação e de valor faturado.
            DataRow[] rows = table.Select();
     

            for (int i = 0; i < rows.Length; i++)
            {
                ValorTotal = ValorTotal + Convert.ToDouble((rows[i]["CD_VALOR_PAGAR"].ToString()));
                contador++;
            }
            txtQtdTransacao.Text = contador.ToString();
            txtValorFaturado.Text = Convert.ToString(ValorTotal);

        }

        private void btnFecharCaixa_Click(object sender, EventArgs e)
        {
            string strSQL = "UPDATE CAIXA " +
                             "SET DT_FINAL = @DT_FINAL,QT_MOVIMENTO =@QT_MOVIMENTO, VL_SALDO_FINAL = @VL_SALDO_FINAL " +
                             "WHERE CAI_NR_CAIXA = @NR_CAIXA";

            comando = new SqlCommand(strSQL, cn);
            DateTime data = DateTime.Now;
            comando.Parameters.AddWithValue("@DT_FINAL", data);
            comando.Parameters.AddWithValue("@QT_MOVIMENTO", contador);
            comando.Parameters.AddWithValue("@VL_SALDO_FINAL", ValorTotal);
            comando.Parameters.AddWithValue("@NR_CAIXA", Convert.ToInt32(Caixa.caixaAberto));

            cn.Open();
            comando.ExecuteNonQuery();
            MessageBox.Show("O caixa foi fechado com o Valor Final de R$" + txtValorFaturado.Text + ",00. Por favor, entre novamente no sistema!", "Confirmação de Saída", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            cn.Close();
            Application.Restart();


        }

        private void txtQtdTransacao_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgvCaixa_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
