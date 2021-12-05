using System;
using System.Data;
using System.Data.SqlClient;
//using System.Windows;
using System.Windows.Forms;

namespace ProjetoParkInn
{
    public partial class FrmSaidaVeiculo : Form
    {
        int fecharForm = 0;
        SqlConnection cn = new SqlConnection(conexao.StringConexao());
        //SqlConnection conexao;
        SqlCommand comando;
        string strSQL, tabelaSelecionadaAux;

        public void recebePlacaSaida()
        {
            txt_PlacaVeiculo.Text = Placa.placaSaida;
            Placa.placaSaida = "";
            fecharForm = 1;
        }






        public FrmSaidaVeiculo()
        {
            InitializeComponent();
            CarregaTabelas();
            recebePlacaSaida();
        }

        public void saidaVeiculo()
        {
            if (!String.IsNullOrEmpty(Placa.placaSaida))
            {
                txt_PlacaVeiculo.Text = Placa.placaSaida;
            }
        }

        private void btn_PesquisaVeiculo_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txt_PlacaVeiculo.Text) || string.IsNullOrEmpty(cmbTabelaPreco.Text))
            {
                MessageBox.Show("Digite uma placa ou selecione a tabela de Preço!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                try
                {
                    double valorPagar = 0;
                    strSQL = "SELECT CD_PLACA , NM_VEICULO , DT_ENTRADA, MOV_NR_TICKET FROM MOVIMENTO WHERE CD_VALOR_PAGAR is null AND CD_PLACA = @CD_PLACA";
                    comando = new SqlCommand(strSQL, cn);
                    comando.Parameters.AddWithValue("@CD_PLACA", txt_PlacaVeiculo.Text);
                    cn.Open();
                    SqlDataReader registro = comando.ExecuteReader();
                    if (registro.Read())
                    {


                        txtTicket.Text = registro["MOV_NR_TICKET"].ToString();
                        txtTicket.Text = txtTicket.Text.PadLeft(7, '0');
                        txt_ModeloVeiculo.Text = registro["NM_VEICULO"].ToString();


                        if (String.IsNullOrEmpty(txt_ModeloVeiculo.Text))
                        {
                            txt_ModeloVeiculo.Text = "Não informado";
                        }
                        msk_dtEntrada.Text = registro["DT_ENTRADA"].ToString();
                        DateTime data = DateTime.Now;
                        DateTime data2 = (DateTime)registro["DT_ENTRADA"];
                        TimeSpan resultado = data - data2;
                        double valorMinutos = Math.Round(resultado.TotalMinutes);
                        string totalminutos = Convert.ToString(Math.Round(resultado.TotalMinutes));
                        //se quiser motrar o resultado em hora:minutos
                        int hours = Convert.ToInt32(totalminutos);
                        hours = hours / 60;
                        int minutes = Convert.ToInt32(totalminutos);
                        minutes = minutes % 60;
                        txt_Minutos.Text = hours.ToString() + ":" + minutes.ToString();
                        cn.Close();
                        try
                        {

                            tabelaSelecionadaAux = cmbTabelaPreco.SelectedItem.ToString();
                            //string tabelaSelecionada = cmbTabelaPreco.SelectedItem.ToString().Substring(3, tabelaSelecionadaAux.Length - 3);
                            tabelaSelecionadaAux = tabelaSelecionadaAux.Substring(0, tabelaSelecionadaAux.IndexOf(" "));
                            string strSQL2 = "SELECT * FROM TABELA_PRECO WHERE ID_TABELA = " + tabelaSelecionadaAux.ToString() + "";
                            comando = new SqlCommand(strSQL2, cn);
                            double valor = resultado.TotalMinutes;
                            cn.Open();
                            SqlDataReader registro2 = comando.ExecuteReader();
                            if (registro2.Read())
                            {
                                lblCPFCliente.Visible = true;
                                msk_CPFCliente.Visible = true;
                                txtFormaPagamento.Text = "Dinheiro";
                                btnDinheiro.UseVisualStyleBackColor = false;
                                btnCredito.Enabled = true;
                                btnDebito.Enabled = true;
                                btnDinheiro.Enabled = true;
                                btnPix.Enabled = true;
                                btnReceber.Enabled = true;

                                string valorPrimeiraHora = registro2["CD_VALOR_MINUTO"].ToString();
                                if (valorMinutos > 60)
                                {
                                    valorPagar = valorPagar + Convert.ToDouble(valorPrimeiraHora);
                                    valorMinutos = valorMinutos - 60;
                                    string minutoAdicional = registro2["CD_MINUTO_ADICIONAL"].ToString();
                                    string valorMinutoAdicional = registro2["CD_VALOR_ADICIONAL"].ToString();

                                    valorMinutos = valorMinutos / Convert.ToInt32(minutoAdicional);
                                    valorMinutos = Math.Round(valorMinutos, 2);


                                    valorPagar = valorPagar + (valorMinutos * Convert.ToDouble(valorMinutoAdicional));
                                    txt_ValorPagar.Text = Convert.ToString(Math.Round(valorPagar, 2));

                                }
                                else
                                {
                                    valorPagar = valorPagar + Convert.ToDouble(valorPrimeiraHora);
                                    txt_ValorPagar.Text = Convert.ToString(valorPagar);
                                }
                                cn.Close();
                            }
                            cn.Close();
                        }
                        catch
                        {

                        }
                    }
                    else
                    {

                        lblCPFCliente.Visible = false;
                        msk_CPFCliente.Visible = false;
                        txt_ValorPagar.Text = "";
                        txt_Minutos.Text = "";
                        txt_ModeloVeiculo.Text = "";
                        msk_dtEntrada.Text = "";
                        txtFormaPagamento.Text = "";
                        btnCredito.Enabled = false;
                        btnDebito.Enabled = false;
                        btnDinheiro.Enabled = false;
                        btnPix.Enabled = false;
                        btnReceber.Enabled = false;
                        //cmbTabelaPreco.SelectedIndex = -1;
                        MessageBox.Show("Não existe essa placa no pátio, por favor verifique a digitação e tente novamente!");

                    }
                    cn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Não foi possível carregar os dados da saída, por favor contate o Suporte!" + ex.ToString());
                }
            }
        }

        private void CarregaTabelas()
        {
            try
            {
                cn.Open();
                strSQL = "SELECT * FROM TABELA_PRECO";
                comando = new SqlCommand(strSQL, cn);
                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = comando;
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                if (dt.Rows.Count >= 1)
                {
                    foreach (DataRow linha in dt.Rows)
                    {
                        cmbTabelaPreco.Items.Add(linha["ID_TABELA"].ToString() + " - " + linha["NM_TABELA"].ToString());
                    }
                }
                cn.Close();
            }
            catch
            {
                MessageBox.Show("Não foi possível carregar as tabelas de preço!");
            }
        }









        private void btn_SaidaVeiculo_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txt_PlacaVeiculo.Text) || String.IsNullOrEmpty(txt_ModeloVeiculo.Text) ||
                String.IsNullOrEmpty(msk_dtEntrada.Text) || String.IsNullOrEmpty(txt_Minutos.Text) ||
                String.IsNullOrEmpty(txt_ValorPagar.Text))
            {
                MessageBox.Show("Por favor, selecione um veículo e a tabela de preço que deseja usar!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                var result = MessageBox.Show("Tem certeza que deseja efetuar a saída do veículo " + txt_PlacaVeiculo.Text + "?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    try
                    {
                        strSQL = "UPDATE MOVIMENTO " +
                            "SET DT_SAIDA = @DT_SAIDA, CD_VALOR_PAGAR = @VL_PAGO, " +
                            "NM_TIPO_RECEBIMENTO = @TIPO_RECEBIMENTO,TABELA_PRECO_ID_TABELA = @ID_TABELA, " +
                            "CPF_CLIENTE_CPF = @CPF, MOV_NR_CAIXA = @NR_CAIXA " +
                            "WHERE CD_PLACA = @CD_PLACA";

                        comando = new SqlCommand(strSQL, cn);
                        DateTime data = DateTime.Now;
                        comando.Parameters.AddWithValue("@DT_SAIDA", data);
                        comando.Parameters.AddWithValue("@VL_PAGO", Convert.ToDouble(txt_ValorPagar.Text));
                        comando.Parameters.AddWithValue("@TIPO_RECEBIMENTO", txtFormaPagamento.Text);
                        comando.Parameters.AddWithValue("@ID_TABELA", tabelaSelecionadaAux.ToString());
                        comando.Parameters.AddWithValue("@CPF", msk_CPFCliente.Text);
                        comando.Parameters.AddWithValue("@NR_CAIXA", Caixa.caixaAberto);
                        comando.Parameters.AddWithValue("@CD_PLACA", txt_PlacaVeiculo.Text);
                        cn.Open();
                        comando.ExecuteNonQuery();
                        MessageBox.Show("O valor de R$" + txt_ValorPagar.Text + ",00 foi recebido com sucesso!", "Confirmação de Saída", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        cn.Close();
                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show("Erro ao efetuar saída do veículo, por favor contate o suporte!" + ex.ToString());
                    }
                    finally
                    {
                        if (fecharForm == 1)
                        {
                            cn.Close();
                            this.Close();
                        }
                        cn.Close();
                        txt_PlacaVeiculo.Text = "";
                        txt_ValorPagar.Text = "";
                        txt_Minutos.Text = "";
                        txt_ModeloVeiculo.Text = "";
                        msk_dtEntrada.Text = "";
                        txtFormaPagamento.Text = "";
                        cmbTabelaPreco.SelectedIndex = -1;
                        lblCPFCliente.Visible = false;
                        msk_CPFCliente.Visible = false;
                        msk_CPFCliente.Text = "";
                        btnCredito.Enabled = false;
                        btnDebito.Enabled = false;
                        btnDinheiro.Enabled = false;
                        btnPix.Enabled = false;
                        btnReceber.Enabled = false;
                    }


                }







            }
        }

        #region BotoesPgamento
        private void btnDebito_Click(object sender, EventArgs e)
        {
            txtFormaPagamento.Text = "Débito";
            btnCredito.UseVisualStyleBackColor = true;
            btnDebito.UseVisualStyleBackColor = false;
            btnDinheiro.UseVisualStyleBackColor = true;
            btnPix.UseVisualStyleBackColor = true;
        }

        private void btnCredito_Click(object sender, EventArgs e)
        {
            txtFormaPagamento.Text = "Crédito";
            btnCredito.UseVisualStyleBackColor = false;
            btnDebito.UseVisualStyleBackColor = true;
            btnDinheiro.UseVisualStyleBackColor = true;
            btnPix.UseVisualStyleBackColor = true;
        }

        private void btnDinheiro_Click(object sender, EventArgs e)
        {
            txtFormaPagamento.Text = "Dinheiro";
            btnCredito.UseVisualStyleBackColor = true;
            btnDebito.UseVisualStyleBackColor = true;
            btnDinheiro.UseVisualStyleBackColor = false;
            btnPix.UseVisualStyleBackColor = true;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnPix_Click(object sender, EventArgs e)
        {
            txtFormaPagamento.Text = "Pix";
            btnCredito.UseVisualStyleBackColor = true;
            btnDebito.UseVisualStyleBackColor = true;
            btnDinheiro.UseVisualStyleBackColor = true;
            btnPix.UseVisualStyleBackColor = false;
        }
        #endregion


    }
}
