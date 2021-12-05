using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;


namespace ProjetoParkInn
{
    public partial class FrmPatioVeiculos : Form
    {
        SqlConnection cn = new SqlConnection(conexao.StringConexao());
        SqlCommand comando;
        string strSQL;
        string ticketVeiculoSelecionado = "";


        public FrmPatioVeiculos()
        {
            InitializeComponent();

        }

        private void PatioVeiculos_Load(object sender, EventArgs e)
        {
            carregaPatio();
        }



        private void carregaPatio()
        {
            try
            {

                cn.Open();
                strSQL = "SELECT CD_PLACA ,NM_VEICULO, MOV_NR_TICKET, DT_ENTRADA FROM MOVIMENTO WHERE CD_VALOR_PAGAR is NULL";
                comando = new SqlCommand(strSQL, cn);
                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = comando;
                DataTable table = new DataTable();
                adapter.Fill(table);
                dgv_PatioVeiculos.DataSource = table;
                cn.Close();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void pegaTicket(string placaSelecionada, DateTime DataEntrada)
        {
            strSQL = "SELECT CD_PLACA , NM_VEICULO , DT_ENTRADA, MOV_NR_TICKET FROM MOVIMENTO WHERE CD_VALOR_PAGAR is null AND CD_PLACA = @CD_PLACA AND DT_ENTRADA like @DT_ENTRADA";
            comando = new SqlCommand(strSQL, cn);
            comando.Parameters.AddWithValue("@CD_PLACA", placaSelecionada.ToString());
            comando.Parameters.AddWithValue("@DT_ENTRADA", DataEntrada);
            cn.Open();
            SqlDataReader registro = comando.ExecuteReader();
            if (registro.Read())
            {
                ticketVeiculoSelecionado = registro["MOV_NR_TICKET"].ToString();
            }
            cn.Close();

        }

        private void dgv_PatioVeiculos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_PatioVeiculos.Columns[e.ColumnIndex] is
                 DataGridViewButtonColumn &&
                e.RowIndex != -1)
            {
                if (e.ColumnIndex == 0)
                {
                    var placaSelecionada = dgv_PatioVeiculos.Rows[e.RowIndex].Cells["clnPlaca"].Value;
                    Placa.placaSaida = placaSelecionada.ToString();
                    FrmSaidaVeiculo irmao = new FrmSaidaVeiculo();
                    irmao.MdiParent = this.MdiParent; // "this" sendo a instância do formulário filho
                    irmao.ShowDialog();
                    carregaPatio();


                }
                else if (e.ColumnIndex == 1)
                {
                    if (Convert.ToInt32(Usuario.Perfil) == 0)
                    {
                        MessageBox.Show("Você não tem permissão para realizar essa ação!", "Acesso Negado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                        var placaSelecionada = dgv_PatioVeiculos.Rows[e.RowIndex].Cells["clnPlaca"].Value;
                        var dataEntrada = dgv_PatioVeiculos.Rows[e.RowIndex].Cells["clnDataEntrada"].Value;
                        var result = MessageBox.Show("Tem certeza que deseja efetuar a remoção do veículo " + placaSelecionada.ToString() + "? Essa ação não poderá ser desfeita!", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                        if (result == DialogResult.Yes)
                        {
                            try
                            {
                                DateTime dataEntradaConvertida = Convert.ToDateTime(dataEntrada);
                                pegaTicket(placaSelecionada.ToString(), dataEntradaConvertida);

                                strSQL = "UPDATE MOVIMENTO " +
                                "SET DT_SAIDA = @DT_SAIDA, CD_VALOR_PAGAR = @VL_PAGO, " +
                                "NM_TIPO_RECEBIMENTO = @TIPO_RECEBIMENTO,TABELA_PRECO_ID_TABELA = @ID_TABELA, " +
                                "CPF_CLIENTE_CPF = @CPF, MOV_NR_CAIXA = @NR_CAIXA " +
                                "WHERE CD_PLACA = @CD_PLACA AND MOV_NR_TICKET = @NR_TICET";

                                comando = new SqlCommand(strSQL, cn);
                                DateTime data = DateTime.Now;
                                comando.Parameters.AddWithValue("@DT_SAIDA", data);
                                comando.Parameters.AddWithValue("@VL_PAGO", Convert.ToDouble(0));
                                comando.Parameters.AddWithValue("@TIPO_RECEBIMENTO", "Remoção do pátio");
                                comando.Parameters.AddWithValue("@ID_TABELA", "0");
                                comando.Parameters.AddWithValue("@CPF", "");
                                comando.Parameters.AddWithValue("@NR_CAIXA", Caixa.caixaAberto);
                                comando.Parameters.AddWithValue("@CD_PLACA", placaSelecionada.ToString());
                                comando.Parameters.AddWithValue("@NR_TICET", ticketVeiculoSelecionado.ToString());
                                cn.Open();
                                comando.ExecuteNonQuery();
                                cn.Close();
                                carregaPatio();

                            }
                            catch
                            {
                                MessageBox.Show("Não foi possível remover o veículo do pátio, por favor contate o suporte!");
                            }
                        }
                    }
                }
            }
        }
    }
}
