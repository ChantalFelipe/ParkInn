using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;


namespace ProjetoParkInn
{
    public partial class FrmCadastroCliente : Form
    {
        SqlConnection cn = new SqlConnection(conexao.StringConexao());
        SqlCommand comando;
        string strSQL;
        int bit = 1;

        public FrmCadastroCliente()
        {
            InitializeComponent();
            carregaClientesCadastrados();
        }

        private void btn_ConfirmaCliente_Click(object sender, EventArgs e)
        {
            //Verifica campos
            if (String.IsNullOrEmpty(msk_CPF.Text) || String.IsNullOrEmpty(msk_RG.Text) ||
                String.IsNullOrEmpty(txtNomeCliente.Text) || String.IsNullOrEmpty(msk_DataNasc.Text))
            {
                MessageBox.Show("Preencha todos os campos!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    //Monta query
                    strSQL = "insert into CLIENTE(CPF_CLIENTE,RG_CLIENTE,NM_CLIENTE,DT_NASCIMENTO,CD_STATUS) " +
                        "values(@CPF_CLIENTE, @RG_CLIENTE, @NM_CLIENTE, @DT_NASCIMENTO, @CD_STATUS_CLIENTE)";

                    comando = new SqlCommand(strSQL, cn);
                    comando.Parameters.AddWithValue("@CPF_CLIENTE", msk_CPF.Text);
                    comando.Parameters.AddWithValue("@RG_CLIENTE", msk_RG.Text);
                    comando.Parameters.AddWithValue("@NM_CLIENTE", txtNomeCliente.Text);
                    comando.Parameters.AddWithValue("@DT_NASCIMENTO", msk_DataNasc.Text);
                    comando.Parameters.AddWithValue("@CD_STATUS_CLIENTE", bit);

                    cn.Open();
                    comando.ExecuteNonQuery();
                    cn.Close();
                    MessageBox.Show("Cliente registrado com sucesso!", "Sucesso!", MessageBoxButtons.OK);
                    comando = null;
                    msk_CPF.Text = "";
                    msk_RG.Text = "";
                    txtNomeCliente.Text = "";
                    msk_DataNasc.Text = "";
                    carregaClientesCadastrados();
                }
                catch
                {
                    try
                    {
                        cn.Close();

                        strSQL = "UPDATE CLIENTE SET CD_STATUS = 1, NM_CLIENTE = @NM_CLIENTE, DT_NASCIMENTO = @DT_NASCIMENTO WHERE CPF_CLIENTE = @CPF AND RG_CLIENTE = @RG_CLIENTE ";

                        comando = new SqlCommand(strSQL, cn);
                        DateTime data = DateTime.Now;
                        comando.Parameters.AddWithValue("@NM_CLIENTE", txtNomeCliente.Text);
                        comando.Parameters.AddWithValue("@CPF", msk_CPF.Text);
                        comando.Parameters.AddWithValue("@RG_CLIENTE", msk_RG.Text);
                        comando.Parameters.AddWithValue("@DT_NASCIMENTO", msk_DataNasc.Text);
                        cn.Open();
                        comando.ExecuteNonQuery();
                        cn.Close();
                        MessageBox.Show("Cliente alterado com sucesso!");
                        carregaClientesCadastrados();
                        msk_CPF.ReadOnly = true;
                        msk_RG.ReadOnly = false;
                        msk_DataNasc.ReadOnly = false;
                        comando = null;
                        msk_CPF.Text = "";
                        msk_RG.Text = "";
                        txtNomeCliente.Text = "";
                        msk_DataNasc.Text = "";
                    }
                    catch
                    {
                        MessageBox.Show("Não foi possível realizar o cadastro, por favor entre em contato com o Suporte!");
                    }


                }

            }







        }

        private void carregaClientesCadastrados()
        {
            try
            {
                cn.Open();
                strSQL = "select NM_CLIENTE, CPF_CLIENTE, RG_CLIENTE, DT_NASCIMENTO from cliente where cd_status = 1";
                comando = new SqlCommand(strSQL, cn);
                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = comando;
                DataTable table = new DataTable();
                adapter.Fill(table);
                dgvClienteCadastrado.DataSource = table;
                cn.Close();

            }
            catch (Exception ex)
            {

                MessageBox.Show("Não foi possível carregar os clientes cadastrados, por favor solicite o suporte." + ex.ToString());
            }
            cn.Close();
        }

        private void dgvClientesCadastrados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void CadastroCliente_Load(object sender, EventArgs e)
        {

        }

        private void dgvClienteCadastrado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvClienteCadastrado.Columns[e.ColumnIndex] is
                 DataGridViewButtonColumn &&
                e.RowIndex != -1)
            {
                if (e.ColumnIndex == 0)
                {
                    txtNomeCliente.Text = Convert.ToString(dgvClienteCadastrado.Rows[e.RowIndex].Cells["clnNome"].Value);
                    msk_CPF.Text = Convert.ToString(dgvClienteCadastrado.Rows[e.RowIndex].Cells["clnCPF"].Value);
                    msk_RG.Text = Convert.ToString(dgvClienteCadastrado.Rows[e.RowIndex].Cells["clnRG"].Value);
                    msk_DataNasc.Text = Convert.ToString(dgvClienteCadastrado.Rows[e.RowIndex].Cells["clnNascimento"].Value);
                    msk_CPF.ReadOnly = true;
                    msk_RG.ReadOnly = true;
                    msk_DataNasc.ReadOnly = false;

                    //carregaClientesCadastrados();


                }
                else if (e.ColumnIndex == 1)
                {

                    var result = MessageBox.Show("Tem certeza que deseja efetuar a remoção do cliente:  " + Convert.ToString(dgvClienteCadastrado.Rows[e.RowIndex].Cells["clnNome"].Value) + "? Essa ação não poderá ser desfeita!", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (result == DialogResult.Yes)
                    {
                        try
                        {
                            cn.Close();

                            strSQL = "UPDATE CLIENTE SET CD_STATUS = 0 WHERE NM_CLIENTE = @NM_CLIENTE AND CPF_CLIENTE = @CPF AND RG_CLIENTE = @RG_CLIENTE ";

                            comando = new SqlCommand(strSQL, cn);
                            DateTime data = DateTime.Now;
                            comando.Parameters.AddWithValue("@NM_CLIENTE", Convert.ToString(dgvClienteCadastrado.Rows[e.RowIndex].Cells["clnNome"].Value));
                            comando.Parameters.AddWithValue("@CPF", Convert.ToString(dgvClienteCadastrado.Rows[e.RowIndex].Cells["clnCPF"].Value));
                            comando.Parameters.AddWithValue("@RG_CLIENTE", Convert.ToString(dgvClienteCadastrado.Rows[e.RowIndex].Cells["clnRG"].Value));
                            cn.Open();
                            comando.ExecuteNonQuery();
                            cn.Close();
                            MessageBox.Show("Cliente removido com sucesso!");
                            carregaClientesCadastrados();

                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Não foi possível excluir o cliente, por favor contate o suporte!" + ex.ToString());
                        }
                    }
                }
            }
        }
    }
}

