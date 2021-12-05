using System;

namespace ProjetoParkInn
{
    public static class Usuario
    {
        private static string m_perfil = "";
        public static string Perfil
        {
            get { return m_perfil; }
            set { m_perfil = value; }
        }
        private static string _login = "";
        public static string Login
        {
            get { return _login; }
            set { _login = value; }
        }
    }

    public static class Caixa
    {
        private static string m_caixa = "";
        public static string caixaAberto
        {
            get { return m_caixa; }
            set { m_caixa = value; }
        }

    }


    public static class Ticket
    {
        private static string m_ticket = "";
        public static string ultimoTicket
        {
            get { return m_ticket; }
            set { m_ticket = value; }
        }

    }

    public static class Placa
    {
        private static string m_placa = "";
        public static string placaSaida
        {
            get { return m_placa; }
            set { m_placa = value; }
        }

    }







    //Aqui vou armazenar oq o ticket precisa para imprimir;
    public static class TicketImpressao
    {
        private static string m_ticket = "";
        public static string Ticket
        {
            get { return m_ticket; }
            set { m_ticket = value; }
        }

        private static string m_placa = "";
        public static string Placa
        {
            get { return m_placa; }
            set { m_placa = value; }
        }

        private static string m_modelo = "";
        public static string Modelo
        {
            get { return m_modelo; }
            set { m_modelo = value; }
        }

        private static DateTime m_entrada;
        public static DateTime Entrada
        {
            get { return m_entrada; }
            set { m_entrada = value; }
        }

        private static DateTime m_saida;
        public static DateTime Saida
        {
            get { return m_saida; }
            set { m_saida = value; }
        }

        private static string m_pemanencia = "";
        public static string Permanencia
        {
            get { return m_pemanencia; }
            set { m_pemanencia = value; }
        }


        private static double m_valorPago = 0;
        public static double ValorPago
        {
            get { return m_valorPago; }
            set { m_valorPago = value; }
        }



    }
}