using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppBanco
{
    class Program
    {
        static void Main(string[] args)
        {
            MySqlConnection conexao = new MySqlConnection("server= localhost; database= dbExemploModular; User ID = root; Password = 12345678");
            conexao.Open();

            string strSelecionaUsu = "Select * from tbUsuario";
            MySqlCommand comando = new MySqlCommand(strSelecionaUsu, conexao);
            MySqlDataReader leitor = comando.ExecuteReader();

            while (leitor.Read())
            {
                Console.WriteLine("Id: {0}, Nome: {1}, Cargo: {2}, Data: {3}", leitor["IdUSu"], leitor["NomeUsu"], leitor["Cargo"], leitor["DataNasc"]);
            }
            Console.ReadLine();

        }
    }
}
