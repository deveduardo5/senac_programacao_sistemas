using MySql.Data.MySqlClient;
using Org.BouncyCastle.Asn1.BC;
using SneakersSenac.banco_de_dados;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace SneakersSenac.repositorio
{
    internal class sneakersRepositorio
    {
        public void Compra(string nome)
        {
            using (var con = DataBase.GetConnection())
            {
                con.Open();
                string query = "INSERT INTO produtos (nome) VALUES (@nome)";
                using (var cmd = new MySqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@nome", nome);
                    cmd.ExecuteNonQuery();
                }
            
            }
         
        }
        public void atualizarestoque (int id, int situacao)
        {
            using (var con = DataBase.GetConnection())
            {
                con.Open();

                string query = "update estoque set quantidade = @quantidade where id = @id;";

                using (var cmd = new MySqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.Parameters.AddWithValue("@situacao", situacao);
                    cmd.ExecuteNonQuery();
                }
            }
        }

    }
}
