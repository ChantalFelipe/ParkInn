using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ProjetoParkInn
{
    public partial class FrmCadastroUsuario : Form
    {
        SqlConnection cn = new SqlConnection(conexao.StringConexao());
        SqlCommand comando;
        string strSQL;
        int permissao = 0;


        public FrmCadastroUsuario()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            carregaUsuariosCadastrados();
        }

        private void btn_ConfirmaUsuario_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txt_NomeUsuario.Text) || String.IsNullOrEmpty(txt_EmailUsuario.Text) ||
                String.IsNullOrEmpty(txt_SenhaUsuario.Text) || String.IsNullOrEmpty(msk_CPFUsuario.Text) || String.IsNullOrEmpty(msk_RGUsuario.Text) ||
                cb_PermissaoUsuario.SelectedIndex.Equals(-1) || String.IsNullOrEmpty(txt_SenhaUsuario2.Text))
            {
                MessageBox.Show("Preencha todos os campos!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (txt_SenhaUsuario2.Text == txt_SenhaUsuario.Text)
                {
                    try
                    {

                        strSQL = "insert into USUARIO_SISTEMA(ID_CPF,NM_USUARIO,NM_EMAIL,CD_RG,CD_SENHA,CD_PERMISSAO)" +
                            "values(@ID_CPF, @NM_USUARIO, @NM_EMAIL, @CD_RG, @CD_SENHA, @CD_PERMISSAO)";

                        comando = new SqlCommand(strSQL, cn);
                        if (cb_PermissaoUsuario.Text == "Administrador")
                        {
                            permissao = 1;
                        }
                        else
                        {
                            permissao = 0;

                        }

                        comando.Parameters.AddWithValue("@ID_CPF", Convert.ToString(msk_CPFUsuario.Text));
                        comando.Parameters.AddWithValue("@NM_USUARIO", txt_NomeUsuario.Text);
                        comando.Parameters.AddWithValue("@NM_EMAIL", txt_EmailUsuario.Text);
                        comando.Parameters.AddWithValue("@CD_RG", msk_RGUsuario.Text);
                        comando.Parameters.AddWithValue("@CD_SENHA", txt_SenhaUsuario.Text);
                        comando.Parameters.AddWithValue("@CD_PERMISSAO", permissao);

                        cn.Open();
                        comando.ExecuteNonQuery();
                        cn.Close();
                        MessageBox.Show("Usuario registrado com sucesso!", "Sucesso!", MessageBoxButtons.OK);

                        //conexao = null;
                        comando = null;
                        msk_CPFUsuario.Text = "";
                        txt_NomeUsuario.Text = "";
                        txt_EmailUsuario.Text = "";
                        msk_RGUsuario.Text = "";
                        txt_SenhaUsuario.Text = "";
                        txt_SenhaUsuario2.Text = "";
                        cb_PermissaoUsuario.Text = "";
                        carregaUsuariosCadastrados();
                        txt_SenhaUsuario.ReadOnly = false;
                        txt_SenhaUsuario2.ReadOnly = false;
                        msk_CPFUsuario.ReadOnly = false;
                        msk_RGUsuario.ReadOnly = false;
                        txt_EmailUsuario.ReadOnly = false;
                        cb_PermissaoUsuario.SelectedIndex = -1;
                    }

                    catch
                    {
                        try
                        {
                            cn.Close();
                            strSQL = "UPDATE USUARIO_SISTEMA SET NM_USUARIO = @NM_USUARIO, NM_EMAIL = @NM_EMAIL, CD_PERMISSAO = @CD_PERMISSAO WHERE  ID_CPF = @ID_CPF AND CD_RG = @RG";

                            comando = new SqlCommand(strSQL, cn);
                            if (cb_PermissaoUsuario.Text == "Administrador")
                            {
                                permissao = 1;
                            }
                            else
                            {
                                permissao = 0;

                            }

                            comando.Parameters.AddWithValue("@ID_CPF", msk_CPFUsuario.Text);
                            comando.Parameters.AddWithValue("@NM_USUARIO", txt_NomeUsuario.Text);
                            comando.Parameters.AddWithValue("@NM_EMAIL", txt_EmailUsuario.Text);
                            comando.Parameters.AddWithValue("@RG", msk_RGUsuario.Text);
                            comando.Parameters.AddWithValue("@CD_PERMISSAO", permissao);

                            cn.Open();
                            comando.ExecuteNonQuery();
                            cn.Close();
                            MessageBox.Show("Usuario alterado com sucesso!", "Sucesso!", MessageBoxButtons.OK);
                  
                            //conexao = null;
                            comando = null;
                            msk_CPFUsuario.Text = "";
                            txt_NomeUsuario.Text = "";
                            txt_EmailUsuario.Text = "";
                            msk_RGUsuario.Text = "";
                            txt_SenhaUsuario.Text = "";
                            txt_SenhaUsuario2.Text = "";
                            cb_PermissaoUsuario.Text = "";
                            carregaUsuariosCadastrados();
                            txt_SenhaUsuario.ReadOnly = false;
                            txt_SenhaUsuario2.ReadOnly = false;
                            msk_CPFUsuario.ReadOnly = false;
                            msk_RGUsuario.ReadOnly = false;
                            txt_EmailUsuario.ReadOnly = false;
                            cb_PermissaoUsuario.SelectedIndex = -1;
                        }
                        catch
                        {
                            MessageBox.Show("Não foi possível atulizar os usuários, por favor contate o suporte para correção!", "Erro!");
                        }

                    }
                }
                else
                {
                    MessageBox.Show("Erro! As senhas não conhecidem!", "Erro!", MessageBoxButtons.OK);
                    txt_SenhaUsuario.Focus();
                }
            }
        }

        private void carregaUsuariosCadastrados()
        {
            try
            {
                cn.Open();
                strSQL = "select nm_usuario, nm_email,ID_CPF, cd_rg, cd_permissao from USUARIO_SISTEMA";
                comando = new SqlCommand(strSQL, cn);
                SqlDataAdapter adapter = new SqlDataAdapter();
                DataTable table = new DataTable();
                adapter.SelectCommand = comando;
                adapter.Fill(table);
                dgvUsuarioCadastrado.DataSource = table;
                cn.Close();

            }
            catch (Exception ex)
            {

                MessageBox.Show("Não foi possível carregar os usuários cadastrados, por favor solicite o suporte." + ex.ToString());
            }

        }

        private void dgvUsuarioCadastrado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dgvUsuarioCadastrado = sender as DataGridView;
            if (dgvUsuarioCadastrado == null)
                return;
            if (dgvUsuarioCadastrado.CurrentRow.Index == 0)
            {
                // 0 = editar
                // 1 = excluir


                MessageBox.Show(dgvUsuarioCadastrado.CurrentCell.ColumnIndex.ToString());
            }





        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void txt_SenhaUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgvClienteCadastrado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvUsuarioCadastrado.Columns[e.ColumnIndex] is
                 DataGridViewButtonColumn &&
                e.RowIndex != -1)
            {
                if (e.ColumnIndex == 0)
                {
                    if (!(Convert.ToString(dgvUsuarioCadastrado.Rows[e.RowIndex].Cells["clnNome"].Value) == Usuario.Login && Convert.ToInt32(dgvUsuarioCadastrado.Rows[e.RowIndex].Cells["clnPermissao"].Value) == Convert.ToInt32(Usuario.Perfil)))
                    {

                        txt_NomeUsuario.Text = Convert.ToString(dgvUsuarioCadastrado.Rows[e.RowIndex].Cells["clnNome"].Value);
                        txt_EmailUsuario.Text = Convert.ToString(dgvUsuarioCadastrado.Rows[e.RowIndex].Cells["clnEmail"].Value);
                        msk_CPFUsuario.Text = Convert.ToString(dgvUsuarioCadastrado.Rows[e.RowIndex].Cells["clnCPF"].Value);

                        msk_RGUsuario.Text = Convert.ToString(dgvUsuarioCadastrado.Rows[e.RowIndex].Cells["clnRG"].Value);
                        if (Convert.ToInt32(dgvUsuarioCadastrado.Rows[e.RowIndex].Cells["clnPermissao"].Value) == 1)
                        {
                            cb_PermissaoUsuario.SelectedIndex = 0;
                        }
                        else
                        {
                            cb_PermissaoUsuario.SelectedIndex = 1;
                        }
                        txt_SenhaUsuario.Text = "Não realizar update";
                        txt_SenhaUsuario2.Text = "Não realizar update";
                        txt_SenhaUsuario.ReadOnly = true;
                        txt_SenhaUsuario2.ReadOnly = true;
                        msk_CPFUsuario.ReadOnly = true;
                        msk_RGUsuario.ReadOnly = true;
                        txt_EmailUsuario.ReadOnly = false;
                    }
                    else
                    {
                        MessageBox.Show("Não é possível alterar o próprio login, por favor altere seu logi pelo menu lateral!");
                    }
                }
                else if (e.ColumnIndex == 1)
                {

                    var result = MessageBox.Show("Tem certeza que deseja efetuar a remoção do usuário:  " + Convert.ToString(dgvUsuarioCadastrado.Rows[e.RowIndex].Cells["clnNome"].Value) + "? Essa ação não poderá ser desfeita!", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (result == DialogResult.Yes)
                    {
                        try
                        {
                            cn.Close();

                            strSQL = "DELETE FROM USUARIO_SISTEMA WHERE nm_usuario = @NM_USUARIO AND nm_email = @NM_EMAIL AND ID_CPF = @ID_CPF AND cd_rg = @CD_RG";
                            comando = new SqlCommand(strSQL, cn);
                            comando.Parameters.AddWithValue("@NM_USUARIO", Convert.ToString(dgvUsuarioCadastrado.Rows[e.RowIndex].Cells["clnNome"].Value));
                            comando.Parameters.AddWithValue("@ID_CPF", Convert.ToString(dgvUsuarioCadastrado.Rows[e.RowIndex].Cells["clnCPF"].Value));
                            comando.Parameters.AddWithValue("@CD_RG", Convert.ToString(dgvUsuarioCadastrado.Rows[e.RowIndex].Cells["clnRG"].Value));
                            comando.Parameters.AddWithValue("@NM_EMAIL", Convert.ToString(dgvUsuarioCadastrado.Rows[e.RowIndex].Cells["clnEmail"].Value));

                            cn.Open();
                            comando.ExecuteNonQuery();
                            cn.Close();
                            MessageBox.Show("Usuário removido com sucesso!");
                            carregaUsuariosCadastrados();

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
