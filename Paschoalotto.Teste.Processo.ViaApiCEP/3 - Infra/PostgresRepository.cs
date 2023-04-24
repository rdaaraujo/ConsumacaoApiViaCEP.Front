using _4___Domain;
using Npgsql;
using System;
using System.Reflection.PortableExecutable;
using System.Security.AccessControl;
using System.Text;

namespace _3___Infra
{
    public class PostgresRepository
    {
        public string connString = "Host=10.20.11.131;Username=bvcartao-user;Password=QEf2PP39hp;Database=postgres";

        public void GenericConnection(string query)
        {
            using (var conn = new NpgsqlConnection(connString))
            {
                conn.Open();

                using (var cmd = new NpgsqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("id", 123);

                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Console.WriteLine("{0} {1}", reader.GetInt32(0), reader.GetString(1));
                        }
                    }
                }
            }
        }
        public List<ReturnApiCEPModel> GetConnection(string query)
        {
            using var conn = new NpgsqlConnection(connString);
            conn.Open();
            using var cmd = new NpgsqlCommand(query, conn);
            using NpgsqlDataReader reader = cmd.ExecuteReader();

            var lista = new List<ReturnApiCEPModel>();
            while (reader.Read())
            {
                lista.Add(new ReturnApiCEPModel()
                {
                    cep = reader.GetString(0),
                    logradouro = reader.GetString(1),
                    complemento = reader.GetString(2),
                    bairro = reader.GetString(3),
                    localidade = reader.GetString(4),
                    uf = reader.GetString(5),
                    ibge = reader.GetInt32(6),
                    gia = reader.GetInt32(7),
                    ddd = reader.GetInt32(8),
                    siafi = reader.GetInt32(9),
                });
            }
            conn.Close();

            return lista;
        }
    }
}


