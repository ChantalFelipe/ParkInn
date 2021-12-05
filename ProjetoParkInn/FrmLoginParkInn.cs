using System;
using System.Data;
using System.Data.SqlClient;
using System.Net;
using System.Net.Mail;
using System.Windows.Forms;

namespace ProjetoParkInn
{
    public partial class FrmLoginParkInn : Form
    {
        public FrmLoginParkInn()
        {
            InitializeComponent();
            txt_LoginUsuario.Select();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_ConfirmaLogin_Click(object sender, EventArgs e)
        {
            //verificando se os campos estao preenchidos
            if (txt_LoginUsuario.TextLength == 0 || txt_SenhaUsuario.TextLength == 0)
            {
                //se estiverem vazios, para a execucao e mostra a mensagem
                MessageBox.Show("Preencha todos os campos!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                try
                {
                    SqlConnection cn = new SqlConnection(conexao.StringConexao());
                    //variaveis para receber o txtbox
                    string usuario = txt_LoginUsuario.Text;
                    string senha = txt_SenhaUsuario.Text;
                    // montando a query
                    string query = "SELECT * FROM USUARIO_SISTEMA WHERE NM_USUARIO = '" + usuario + "' and CD_SENHA = '" + senha + "'";
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
                            Usuario.Perfil = linha["CD_PERMISSAO"].ToString();
                        }
                        Usuario.Login = txt_LoginUsuario.Text;

                        FrmMenu menu = new FrmMenu();
                        this.Hide();
                        menu.Show();
                        cn.Close();
                        //MessageBox.Show("Login efetuado com Sucesso!", "Sucesso!");
                    }
                    else
                    {
                        MessageBox.Show("Usuário ou Senha incorreto, tente novamente!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txt_LoginUsuario.Text = "";
                        txt_SenhaUsuario.Text = "";
                        txt_LoginUsuario.Select();
                        cn.Close();
                    }

                }
                catch (SqlException erro)
                {
                    MessageBox.Show("Erro ao tentar se conectar com o banco de dados!" + erro);
                }



            }
        }

        private void LoginParkInn_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void txt_SenhaUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txt_SenhaUsuario_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_ConfirmaLogin.PerformClick();
            }

        }
        #region EnvioEmail
        private void label3_Click(object sender, EventArgs e)
        {
            pnlRecuperarSenha.Visible = true;
        }

        private void lblVoltar_Click(object sender, EventArgs e)
        {
            pnlRecuperarSenha.Visible = false;
        }

        private void btnRecuperarSenha_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtEmailRecuperado.Text))
            {
                MessageBox.Show("Preencha o seu email!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                SqlConnection cn = new SqlConnection(conexao.StringConexao());
                // montando a query
                string query = "SELECT * FROM USUARIO_SISTEMA WHERE NM_EMAIL = '" + txtEmailRecuperado.Text + "'";
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
                    cn.Close();
                    long tickCount = System.Diagnostics.Stopwatch.GetTimestamp();
                    DateTime highResDateTime = new DateTime(tickCount);


                    try
                    {
                        MailMessage mail = new MailMessage();

                        mail.From = new MailAddress("contato@parkinn.com");
                        mail.To.Add(txtEmailRecuperado.Text); // para
                        mail.Subject = "Recuperação de Senha"; // assunto
                        mail.IsBodyHtml = true;
                        //var email = "";
                        mail.Body = "A sua nova senha para entrar no sistema é: " + Convert.ToString(tickCount);
                        using (var smtp = new SmtpClient("smtp.gmail.com"))
                        {
                            smtp.EnableSsl = true; // GMail requer SSL
                            smtp.Port = 587;       // porta para SSL
                            smtp.EnableSsl = true;
                            smtp.DeliveryMethod = SmtpDeliveryMethod.Network; // modo de envio
                            smtp.UseDefaultCredentials = false; // vamos utilizar credencias especificas
                                                                // seu usuário e senha para autenticação
                            smtp.Credentials = new NetworkCredential("projetoparkinn@gmail.com", "parkinn2021");

                            // envia o e-mail
                            smtp.Send(mail);
                            salvaSenha(Convert.ToString(tickCount));
                            MessageBox.Show("Sua nova senha foi enviada para o email informado!");
                            txtEmailRecuperado.Text = "";
                            pnlRecuperarSenha.Visible = false;
                        }
                        cn.Close();
                    }
                    catch
                    {

                        MessageBox.Show("Não foi possível enviar o email, por favor contate o suporte.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    cn.Close();
                    MessageBox.Show("Email não encontrado no banco de dados, por favor verifique a ortografia!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtEmailRecuperado.Focus();
                }
            }
        }

        private void salvaSenha(string tickEnviado)
        {
            try
            {
                SqlConnection cn = new SqlConnection(conexao.StringConexao());
                // montando a query
                string query = "UPDATE USUARIO_SISTEMA SET CD_SENHA = '" + tickEnviado + "' WHERE NM_EMAIL = '" + txtEmailRecuperado.Text + "'";
                //abrindo a conexao
                cn.Open();
                //rodando a consulta 
                SqlCommand comando = new SqlCommand(query, cn);
                comando.ExecuteNonQuery();
                cn.Close();
            }
            catch
            {
                MessageBox.Show("Não foi possível salvar a senha no Banco de Dados, por favor solicite correção ao suporte.");
            }


        }


        #endregion
    }

}

