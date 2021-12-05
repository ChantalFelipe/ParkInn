using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ProjetoParkInn
{
    public partial class FrmTrocarSenha : Form
    {
        SqlConnection cn = new SqlConnection(conexao.StringConexao());
        public FrmTrocarSenha()
        {
            InitializeComponent();
        }

        private void FrmTrocarSenha_Load(object sender, EventArgs e)
        {

            try
            {
                string query = "SELECT * FROM USUARIO_SISTEMA WHERE NM_USUARIO = '" + Usuario.Login + "'";
                //abrindo a conexao
                cn.Open();
                //rodando a consulta 
                SqlDataAdapter dp = new SqlDataAdapter(query, cn);
                //criando uma tabela para receber valores
                DataTable dt = new DataTable();
                //jogano o resultado da query na tabela 
                dp.Fill(dt);
                //verificando se a tabela tem alguma linha
                if (dt.Rows.Count == 1)
                {
                    foreach (DataRow linha in dt.Rows)
                    {
                        txtNome.Text = linha["NM_USUARIO"].ToString();
                        txtEmail.Text = linha["NM_EMAIL"].ToString();
                        txtSenha1.Text = linha["CD_SENHA"].ToString();
                        txtSenha2.Text = linha["CD_SENHA"].ToString();
                    }
                    cn.Close();
                }
            }
            catch
            {
                MessageBox.Show("Não foi possível recuperar os dados do seu usuário. Por favor, contate o suporte!");
            }

        }

        private void btnRecuperarSenha_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNome.Text) || string.IsNullOrWhiteSpace(txtEmail.Text) ||
               string.IsNullOrWhiteSpace(txtSenha1.Text) || string.IsNullOrWhiteSpace(txtSenha2.Text))
            {
                MessageBox.Show("Preencha todos os campos!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtSenha1.Text == txtSenha2.Text)
            {
                string strSQL = "UPDATE USUARIO_SISTEMA " +
                           "SET NM_USUARIO = @NM_USUARIO, CD_SENHA = @SENHA " +
                           "WHERE NM_EMAIL = @NM_EMAIL";

                SqlCommand comando = new SqlCommand(strSQL, cn);
                DateTime data = DateTime.Now;
                comando.Parameters.AddWithValue("@NM_USUARIO", txtNome.Text);
                comando.Parameters.AddWithValue("@SENHA", txtSenha1.Text);
                comando.Parameters.AddWithValue("@NM_EMAIL", txtEmail.Text);

                cn.Open();
                comando.ExecuteNonQuery();
                MessageBox.Show("Os seus dados foram atualizados com sucesso!", "Atualização", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Usuario.Login = txtNome.Text;
                cn.Close();
                this.Close();
            }
            else
            {
                MessageBox.Show("As senhas não conhecidem!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSenha1.Focus();
            }
        }
    }
}
