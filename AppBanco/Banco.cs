using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppBanco
{
    class Banco : IDisposable
    {
        private readonly MySqlConnection conexao;

        public Banco()
        {
            conexao = new MySqlConnection("server=localhost;database=dbexemploModular;user id=root;password=12345678");
            conexao.Open();
        }

        public void ExecutaComando(string StrQuery)
        { 
            var vComando = new MySqlCommand
            {
                CommandText = StrQuery,
                CommandType = CommandType.Text,
                Connection = conexao
            };
        }

        public MySqlDataReader RetornaComando (string StrQuery)
        {
            var comando = new MySqlCommand(StrQuery, conexao);
            return comando.ExecuteReader();
        }

        public void Dispose()
        {
            if (conexao.State==ConnectionState.Open)
                conexao.Close();
        }
    }
}
