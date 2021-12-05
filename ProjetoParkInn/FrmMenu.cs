using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ProjetoParkInn
{
    public partial class FrmMenu : Form
    {
        SqlConnection cn = new SqlConnection(conexao.StringConexao());
        public FrmMenu()
        {
            InitializeComponent();
            customSubMenu();
            customSubMenu2();
            verificaUsuario();
            verificaCaixaAberto();
            RecuperaNumeroTicket();

        }

        private void verificaUsuario()
        {
            label1.Text = "Bem vindo, " + Usuario.Login + " !";
            if (Usuario.Perfil == "0")
            {
                btn_Cadastros.Visible = false;
                btn_TabelaPreco.Visible = false;
                btnRelatorio.Visible = false;
            }
        }

        private void verificaCaixaAberto()
        {
            try
            {
                SqlCommand comando;

                // montando a query
                string query = "SELECT * FROM CAIXA WHERE DT_FINAL IS NULL";
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
                        Caixa.caixaAberto = linha["CAI_NR_CAIXA"].ToString();
                    }
                    cn.Close();
                }
                else
                {

                    string query2 = "selecT top (1) * from caixa order by cai_nr_caixa desc";
                    comando = new SqlCommand(query2, cn);
                    SqlDataReader registro = comando.ExecuteReader();
                    if (registro.Read())
                    {

                        int numeroCaixaAux = Convert.ToInt32(registro["CAI_NR_CAIXA"].ToString());

                        Caixa.caixaAberto = Convert.ToString((numeroCaixaAux + 1));

                        registro.Close();
                        try
                        {

                            string query3 = "INSERT INTO CAIXA (DT_INCIAL,CAI_NR_CAIXA) VALUES('" + DateTime.Now + "'," + Convert.ToInt32(Caixa.caixaAberto) + ")";
                            comando = new SqlCommand(query3, cn);
                            comando.ExecuteNonQuery();
                            cn.Close();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Não foi possível abrir um caixa, contate o suporte para conseguir atendimento." + ex.ToString());
                        }

                    }
                    cn.Close();
                }
            }
            catch
            {
                MessageBox.Show("Não foi possível recuperar o caixa aberto, por favor contate o suporte!", "Erro ao inicializar", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }


        private void RecuperaNumeroTicket()
        {

            // montando a query
            string query = "SELECT TOP (1) MOV_NR_TICKET from MOVIMENTO order by ID_MOVIMENTO desc";
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
                    int numeroTicket = Convert.ToInt32(linha["MOV_NR_TICKET"].ToString());
                    Ticket.ultimoTicket = Convert.ToString((numeroTicket + 1));
                }
                cn.Close();
            }
            else
            {
                cn.Close();
            }
        }

        #region Menu
        private void customSubMenu()
        {
            panelSubMenu.Visible = false;
        }
        private void customSubMenu2()
        {
            panelSubMenu2.Visible = false;
        }
        private void escondeSubMenu2()
        {
            if (panelSubMenu2.Visible == true)
            {
                panelSubMenu2.Visible = false;
            }
        }

        private void escondeSubMenu()
        {
            if (panelSubMenu.Visible == true)
            {
                panelSubMenu.Visible = false;
            }
        }

        private void mostraSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                escondeSubMenu();
                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible = false;
            }


        }

        private void mostraSubMenu2(Panel subMenu2)
        {
            if (subMenu2.Visible == false)
            {
                escondeSubMenu2();
                subMenu2.Visible = true;
            }
            else
            {
                subMenu2.Visible = false;
            }


        }



        private void PatioVeiculos_Load(object sender, EventArgs e)
        {

        }


        private void btn_Cadastros_Click(object sender, EventArgs e)
        {
            mostraSubMenu(panelSubMenu);
            //escondeSubMenu();
            escondeSubMenu2();
            RemoverCorMenu();
            btn_Cadastros.ForeColor = System.Drawing.Color.LightCoral;

        }

        private Form activeForm = null;
        private void abrirChildForm(Form childForm)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panel.Controls.Add(childForm);
            panel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void btn_EntradaVeiculo_Click(object sender, EventArgs e)
        {
            EntradaVeiculo irmao = new EntradaVeiculo();
            irmao.MdiParent = this.MdiParent; // "this" sendo a instância do formulário filho
            irmao.ShowDialog();

            //abrirChildForm(new EntradaVeiculo());
            escondeSubMenu();
            escondeSubMenu2();
            RemoverCorMenu();
            btn_EntradaVeiculo.ForeColor = System.Drawing.Color.LightCoral;

        }

        private void btn_SaidaVeiculo_Click(object sender, EventArgs e)
        {

            abrirChildForm(new FrmSaidaVeiculo());
            escondeSubMenu();
            escondeSubMenu2();
            RemoverCorMenu();
            btn_SaidaVeiculo.ForeColor = System.Drawing.Color.LightCoral;

        }

        private void btn_Patio_Click(object sender, EventArgs e)
        {
            abrirChildForm(new FrmPatioVeiculos());
            escondeSubMenu();
            escondeSubMenu2();
            RemoverCorMenu();
            btn_Patio.ForeColor = System.Drawing.Color.LightCoral;
        }

        private void btn_TabelaPreco_Click(object sender, EventArgs e)
        {
            abrirChildForm(new FrmTabelaPreco());
            RemoverCorMenu();
            btn_TabelaPreco.ForeColor = System.Drawing.Color.LightCoral;
            escondeSubMenu();
            escondeSubMenu2();

        }

        private void btn_CadClienteS_Click_1(object sender, EventArgs e)
        {
            abrirChildForm(new FrmCadastroCliente());
            RemoverCorMenu();
            btn_CadClienteS.ForeColor = System.Drawing.Color.LightCoral;
            escondeSubMenu2();
        }

        private void btn_CadUsuarioS_Click_1(object sender, EventArgs e)
        {
            abrirChildForm(new FrmCadastroUsuario());
            RemoverCorMenu();
            btn_CadUsuarioS.ForeColor = System.Drawing.Color.LightCoral;
            escondeSubMenu2();
        }

        private void btnCaixa_Click(object sender, EventArgs e)
        {
            RemoverCorMenu();
            btnCaixa.ForeColor = System.Drawing.Color.LightCoral;
            mostraSubMenu2(panelSubMenu2);
            escondeSubMenu();

        }

        private void btnSair_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente sair?",
                               "Aviso",
                               MessageBoxButtons.YesNo,
                               MessageBoxIcon.Question,
                               MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                Application.Exit();
            }


        }

        private void btn_Logout_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente deslogar?",
                               "Aviso",
                               MessageBoxButtons.YesNo,
                               MessageBoxIcon.Question,
                               MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                FrmLoginParkInn login = new FrmLoginParkInn();
                this.Hide();
                login.Show();


            }
        }
        private void btnFecharCaixa_Click(object sender, EventArgs e)
        {
            abrirChildForm(new FrmCaixa());
            escondeSubMenu();
            RemoverCorMenu();
            btnFecharCaixa.ForeColor = System.Drawing.Color.LightCoral;
        }

        private void btnRelatorio_Click(object sender, EventArgs e)
        {
            RemoverCorMenu();
            btnRelatorio.ForeColor = System.Drawing.Color.LightCoral;
            abrirChildForm(new FrmRelatorio());
            escondeSubMenu();
        }


        private void RemoverCorMenu()
        {
            btn_CadClienteS.ForeColor = System.Drawing.Color.DimGray;
            btnCaixa.ForeColor = System.Drawing.Color.DimGray;
            btnFecharCaixa.ForeColor = System.Drawing.Color.DimGray;
            btnRelatorio.ForeColor = System.Drawing.Color.DimGray;
            btn_Cadastros.ForeColor = System.Drawing.Color.DimGray;
            btn_EntradaVeiculo.ForeColor = System.Drawing.Color.DimGray;
            btn_SaidaVeiculo.ForeColor = System.Drawing.Color.DimGray;
            btn_Patio.ForeColor = System.Drawing.Color.DimGray;
            btn_TabelaPreco.ForeColor = System.Drawing.Color.DimGray;
            btn_CadUsuarioS.ForeColor = System.Drawing.Color.DimGray;
        }
        private void btnAlterarSenha_Click(object sender, EventArgs e)
        {
            FrmTrocarSenha irmao = new FrmTrocarSenha();
            irmao.MdiParent = this.MdiParent; // "this" sendo a instância do formulário filho
            irmao.ShowDialog();

        }

        #endregion


    }
}
