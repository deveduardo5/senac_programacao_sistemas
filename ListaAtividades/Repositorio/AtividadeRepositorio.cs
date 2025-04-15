using ListaAtividades.banco_de_dados;
using ListaAtividades.Dominio;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaAtividades.Repositorio
{
    internal class AtividadeRepositorio
    {
        public void Criar(string titulo)
        {
            using (var con = DataBase.GetConnection())
            { 
                con.Open();

                string query = "insert into atividade (titulo) values (@titulo);";

                using (var cmd = new MySqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@titulo", titulo);
                    cmd.ExecuteNonQuery();
                }
            }
        }
        public void AtualizarSituacao(int id, int novaSituacao)
        {
            using (var con = DataBase.GetConnection())
            {
                con.Open();

                string query = "update atividade set situacao = @situacao where id = @id;";

                using (var cmd = new MySqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.Parameters.AddWithValue("@situacao", novaSituacao);
                    cmd.ExecuteNonQuery();
                }
            }
        }
        public Atividade BuscarAtividadeEmAndamento()
        {
            using (var con = DataBase.GetConnection())
            {  
                con.Open();

                string query = $"select * from atividade where situacao = {Situacao.Realizando};";

                using (var cmd = new MySqlCommand(query, con))
                {
                    using (var reader = cmd.ExecuteReader())
                    { 
                        if (reader.Read())
                        {
                            return new Atividade()
                            {
                                Id = reader.GetInt32("Id"),
                                Titulo = reader.GetString("titulo"),
                                Situacao = (Situacao)reader.GetInt32("situcao")
                            };
                        }
                    }
                }

            }

                return new Atividade(); 
        }

        public List<Atividade> ListarAtividadesPendentes()
        {
            List<Atividade> atividades = [];

            using (var con = DataBase.GetConnection())
            {
                con.Open();
                
                string query = $"select* from atividade where situacao = {Situacao.Pendente};";

                using (var cmd = new MySqlCommand(query, con))
                {
                    using (var reader = cmd.ExecuteReader())
                    { 
                        while (reader.Read())
                        {
                            atividades.Add(new Atividade()
                            {
                                Id = reader.GetInt32("id"),
                                Titulo = reader.GetString("titulo"),
                                Situacao = (Situacao)reader.GetInt32("situacao")
                            });
                        }
                    }
                }
            }

                return atividades;
        }
    }
}
