using System;
using System.Data;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace ProjetoParkInn
{
    public partial class EntradaVeiculo : Form
    {
        public EntradaVeiculo()
        {
            InitializeComponent();


        }

        private void EntradaCarro_Load(object sender, EventArgs e)
        {

        }

        private void btn_ConfirmaEntrada_Click(object sender, EventArgs e)
        {
            //verifica placa valida
            if (txt_PlacaVeiculo.TextLength < 7)
            {
                MessageBox.Show("Digite uma placa!");
            }
            else
            {
                string placa_txt = txt_PlacaVeiculo.Text;
                var resultado = ValidarPlaca(placa_txt);


                bool ValidarPlaca(string placa)
                {
                    if (string.IsNullOrWhiteSpace(placa)) { return false; }
                    placa = placa.Replace("-", "").Trim();
                    if (placa.Length >= 8) { return false; }

                    //verifica se o 4 caracter e letra
                    if (char.IsLetter(placa, 4))
                    {
                        //verifica mercosul
                        var padraoMercosul = new Regex("[a-zA-Z]{3}[0-9]{1}[a-zA-Z]{1}[0-9]{2}");
                        return padraoMercosul.IsMatch(placa);
                    }
                    else
                    {
                        //verifica placa normal
                        var padraoNormal = new Regex("[a-zA-Z]{3}[0-9]{4}");
                        return padraoNormal.IsMatch(placa);
                    }

                }
                //verifica o resultado da validacao da placa
                if (resultado == false)
                {
                    MessageBox.Show("Digite uma placa válida!");
                    txt_PlacaVeiculo.Text = "";
                }
                else
                {

                    try
                    {
                        SqlConnection cn = new SqlConnection(conexao.StringConexao());
                        cn.Open();
                        string query = "SELECT * FROM MOVIMENTO WHERE CD_PLACA = '" + txt_PlacaVeiculo.Text + "' AND DT_SAIDA IS NULL";
                        SqlDataAdapter dp = new SqlDataAdapter(query, cn);
                        //criando uma tabela para receber valores
                        DataTable dt = new DataTable();
                        //jogano o resultado da consulta na tabela 
                        dp.Fill(dt);
                        //verificando se a tabela tem alguma linha
                        if (dt.Rows.Count == 1)
                        {
                            txt_PlacaVeiculo.Text = "";
                            MessageBox.Show("Essa placa esta no pátio!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                            //tentar inserir o carro na MOVIMENTO
                            try
                            {
                                int ultimoTicket = Convert.ToInt32(Ticket.ultimoTicket);
                                string sql = "INSERT INTO MOVIMENTO(CD_PLACA, NM_VEICULO, DT_ENTRADA, MOV_NR_TICKET, MOV_NR_CAIXA) VALUES(@placa, @modelo, @data, @ticket,@MOV_NR_CAIXA)";
                                DateTime data = DateTime.Now;
                                SqlCommand comando = new SqlCommand(sql, cn);
                                //Adicionando o valor das textBox nos parametros do comando
                                comando.Parameters.Add(new SqlParameter("@placa", this.txt_PlacaVeiculo.Text));
                                comando.Parameters.Add(new SqlParameter("@modelo", this.txt_ModeloVeiculo.Text));
                                comando.Parameters.Add(new SqlParameter("@MOV_NR_CAIXA", Convert.ToInt32(Caixa.caixaAberto)));
                                comando.Parameters.Add(new SqlParameter("@data", data));
                                comando.Parameters.Add(new SqlParameter("@ticket", ultimoTicket));

                                //comando.Parameters.Add(new SqlParameter("@tabela", tabela));


                                //executa o comando com os parametros que foram adicionados acima
                                comando.ExecuteNonQuery();
                                lblEntradaSucesso.Text = "Entrada da placa " + txt_PlacaVeiculo.Text + " efetuada com sucesso!";
                                lblEntradaSucesso.Visible = true;
                                //MessageBox.Show("Entrada da placa " + txt_PlacaVeiculo.Text + " efetuada com sucesso!");
                                txt_PlacaVeiculo.Text = "";
                                txt_ModeloVeiculo.Text = "";
                                Ticket.ultimoTicket = Convert.ToString(ultimoTicket + 1);

                                //fecha a conexao
                                cn.Close();

                            }
                            catch (Exception ex)
                            {

                                MessageBox.Show(ex.Message);

                            }
                            finally
                            {
                                cn.Close();
                            }

                    }
                    catch (SqlException erro)
                    {
                        MessageBox.Show("Erro no banco!" + erro);
                    }

                }
            }
        }


    }
}
