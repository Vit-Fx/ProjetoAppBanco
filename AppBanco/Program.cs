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

            Console.WriteLine("Digite o nome do usuário");
            string vNome = Console.ReadLine();

            Console.WriteLine("Digite o cargo do usuário");
            string vCargo = Console.ReadLine();

            Console.WriteLine("Digite a data de nascimento do usuário");
            string vData = Console.ReadLine();

            MySqlConnection conexao = new MySqlConnection("Server= localhost; database = dbexemploModular; UserID = root; Password = 12345678");
            conexao.Open();

            string strinsereUsu = string.Format("INSERT INTO tbUsuario(NomeUsu,Cargo,Data)" + "VALUES('{0}', '{1}', '{2}');", vNome,vCargo,vData);

            MySqlCommand comandoApagar = new MySqlCommand(strinsereUsu, conexao);
            comandoApagar.ExecuteNonQuery();

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

//string strinsereUsu = "INSERT INTO tbusuario(NomeUsu,Cargo,DataNasc) VALUES ('Emma', 'Cerimonialista', '2000/04/17');";

//MySqlCommand comandoApagar = new MySqlCommand("Delete from tbUsuario where IdUsu=2", conexao);
//comandoApagar.ExecuteNonQuery();

//string strAtualizaUsu = "update tbUsuario set NomeUsu = 'Me acho esperta' where IdUsu=2";
//MySqlCommand comandoAtualiza = new MySqlCommand(strAtualizaUsu, conexao);
//comandoAtualiza.ExecuteNonQuery();

//MySqlCommand comando = new MySqlCommand("update tbUsuario set NomeUsu = 'Me acho esperta' where IdUsu=2", conexao);
//comando.ExecuteNonQuery();

//comando.CommandText = "Select * From tbusuario";
//MySqlDataReader leitor = comando.ExecuteReader();
