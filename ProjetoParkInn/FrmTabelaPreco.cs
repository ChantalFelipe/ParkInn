using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;


namespace ProjetoParkInn
{
    public partial class FrmTabelaPreco : Form
    {
        SqlConnection cn = new SqlConnection(conexao.StringConexao());
        SqlCommand comando;
        string strSQL;
        int idTabela = 0;

        public FrmTabelaPreco()
        {
            InitializeComponent();
            carregaTabelasCadastradas();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btn_ConfirmaTabela_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(msk_ValorMinuto.Text) || String.IsNullOrEmpty(msk_ValorMinutoA.Text) || String.IsNullOrEmpty(txt_Minuto.Text) ||
                String.IsNullOrEmpty(txt_MinutoA.Text) || String.IsNullOrEmpty(txt_NomeTabela.Text))
            {
                MessageBox.Show("Preencha todos os campos!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    strSQL = "INSERT INTO TABELA_PRECO(NM_TABELA,CD_MINUTO_ADICIONAL,CD_VALOR_ADICIONAL,CD_MINUTO,CD_VALOR_MINUTO)" +
                              "VALUES(@NM_TABELA, @QT_MINUTO_ADICIONAL, @VL_MINUTO_ADICIONAL, @QT_MINUTO, @VL_MINUTO )";
                    comando = new SqlCommand(strSQL, cn);

                    int valorMA = Convert.ToInt32(msk_ValorMinutoA.Text);
                    double valorM = Convert.ToDouble(msk_ValorMinuto.Text.Replace("R$", ""));
                    int qtMinuto = Convert.ToInt32(txt_Minuto.Text);
                    int qtMinutoA = Convert.ToInt32(txt_MinutoA.Text);


                    comando.Parameters.AddWithValue("@NM_TABELA", txt_NomeTabela.Text);
                    comando.Parameters.AddWithValue("@QT_MINUTO_ADICIONAL", qtMinutoA);
                    comando.Parameters.AddWithValue("@VL_MINUTO_ADICIONAL", valorMA);
                    comando.Parameters.AddWithValue("@QT_MINUTO", qtMinuto);
                    comando.Parameters.AddWithValue("@VL_MINUTO", valorM);

                    cn.Open();
                    comando.ExecuteNonQuery();
                    MessageBox.Show("Tabela registrada com sucesso!", "Sucesso!", MessageBoxButtons.OK);
                    cn.Close();
                    carregaTabelasCadastradas();
                    cn = null;
                    comando = null;
                    msk_ValorMinutoA.Text = "";
                    msk_ValorMinuto.Text = "";
                    txt_NomeTabela.Text = "";
                    txt_Minuto.Text = "";
                    txt_MinutoA.Text = "";


                }
                catch
                {

                    try
                    {
                        cn.Close();

                        strSQL = "UPDATE TABELA_PRECO SET NM_TABELA = @NM_TABELA, CD_MINUTO_ADICIONAL = @CD_MINUTO_ADICIONAL, CD_VALOR_ADICIONAL = @CD_VALOR_ADICIONAL,CD_MINUTO = @CD_MINUTO,CD_VALOR_MINUTO = @CD_VALOR_MINUTO WHERE ID_TABELA = "+ idTabela;

                        comando = new SqlCommand(strSQL, cn);
                        comando.Parameters.AddWithValue("@NM_TABELA", txt_NomeTabela.Text);
                        comando.Parameters.AddWithValue("@CD_MINUTO_ADICIONAL", Convert.ToInt32(txt_MinutoA.Text));
                        comando.Parameters.AddWithValue("@CD_VALOR_ADICIONAL", Convert.ToDouble(msk_ValorMinutoA.Text));
                        comando.Parameters.AddWithValue("@CD_MINUTO", Convert.ToInt32(txt_Minuto.Text));
                        comando.Parameters.AddWithValue("@CD_VALOR_MINUTO", Convert.ToDouble(msk_ValorMinuto.Text));
                        cn.Open();
                        comando.ExecuteNonQuery();
                        cn.Close();
                        MessageBox.Show("Tabela alterada com sucesso!");
                        carregaTabelasCadastradas();
                        msk_ValorMinutoA.Text = "";
                        msk_ValorMinuto.Text = "";
                        txt_NomeTabela.Text = "";
                        txt_Minuto.Text = "";
                        txt_MinutoA.Text = "";

                    }
                    catch
                    {
                        MessageBox.Show("Não foi possível salvar a tabela, por favor entre em contato com o Suporte!");
                    }
                }
            }
        }

        private void TabelaPreco_Load(object sender, EventArgs e)
        {

        }

        private void carregaTabelasCadastradas()
        {
            try
            {
                cn.Open();
                strSQL = "SELECT ID_TABELA,NM_TABELA,CD_MINUTO,CD_VALOR_MINUTO,CD_MINUTO_ADICIONAL, CD_VALOR_ADICIONAL FROM TABELA_PRECO";
                comando = new SqlCommand(strSQL, cn);
                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = comando;
                DataTable table = new DataTable();
                adapter.Fill(table);
                dgvTabelaDePreco.DataSource = table;
                cn.Close();

            }
            catch (Exception ex)
            {

                MessageBox.Show("Não foi possível carregar as tabelas cadastradas, por favor solicite o suporte." + ex.ToString());
            }
            cn.Close();
        }

        private void dgvClienteCadastrado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (dgvTabelaDePreco.Columns[e.ColumnIndex] is
                 DataGridViewButtonColumn &&
                e.RowIndex != -1)
            {
                if (e.ColumnIndex == 0)
                {
                    txt_NomeTabela.Text = Convert.ToString(dgvTabelaDePreco.Rows[e.RowIndex].Cells["clnNome"].Value);
                    txt_Minuto.Text = Convert.ToString(dgvTabelaDePreco.Rows[e.RowIndex].Cells["clnPrimeiraHora"].Value);
                    msk_ValorMinuto.Text = Convert.ToString(dgvTabelaDePreco.Rows[e.RowIndex].Cells["clnValorPrimeiraHora"].Value);
                    txt_MinutoA.Text = Convert.ToString(dgvTabelaDePreco.Rows[e.RowIndex].Cells["clnMinutosAdicional"].Value);
                    msk_ValorMinutoA.Text = Convert.ToString(dgvTabelaDePreco.Rows[e.RowIndex].Cells["clnValorAdicional"].Value);
                    idTabela = Convert.ToInt32(dgvTabelaDePreco.Rows[e.RowIndex].Cells["clnIdTabela"].Value);
                }
                else if (e.ColumnIndex == 1)
                {

                    var result = MessageBox.Show("Tem certeza que deseja efetuar a remoção da tabela:  "
                        + Convert.ToString(dgvTabelaDePreco.Rows[e.RowIndex].Cells["clnIdTabela"].Value) + " - "
                        + Convert.ToString(dgvTabelaDePreco.Rows[e.RowIndex].Cells["clnNome"].Value) +
                        "? Essa ação não poderá ser desfeita!", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (result == DialogResult.Yes)
                    {
                        try
                        {
                            cn.Close();

                            strSQL = "DELETE FROM TABELA_PRECO WHERE ID_TABELA = @ID_TABELA";

                            comando = new SqlCommand(strSQL, cn);
                            comando.Parameters.AddWithValue("@ID_TABELA", Convert.ToInt32(dgvTabelaDePreco.Rows[e.RowIndex].Cells["clnIdTabela"].Value));
                            cn.Open();
                            comando.ExecuteNonQuery();
                            cn.Close();
                            MessageBox.Show("Tabela removida com suceso!");
                            carregaTabelasCadastradas();

                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Não foi possível excluir a tabela, por favor contate o suporte!" + ex.ToString());
                        }
                    }
                }

            }
        }
    }
}
