using _4___Domain;
using _3___Infra;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2___Services
{
    public class Crud
    {
        public PostgresRepository postgresRepository = new PostgresRepository();
        public void insertData(ReturnApiCEPModel dados)
        {
            var query = $"INSERT INTO tabela_ceps (" +
                        $"cep_str, logradouro_str, complemento_str, bairro_str, localidade_str, uf_str, ibge_int, gia_int, ddd_int, siafi_int, tstamp)" +
                        $"values (" +
                        $"'{dados.cep}', '{dados.logradouro}', '{dados.complemento}', '{dados.bairro}', '{dados.localidade}', '{dados.uf}', " +
                        $"{dados.ibge}, {dados.gia}, {dados.ddd}, {dados.siafi}, current_timestamp)";
            postgresRepository.GenericConnection(query);
        }

        public void updateData(ReturnApiCEPModel dados)
        {
            var query = $"UPDATE tabela_ceps SET " +
                        $"logradouro_str = '{dados.logradouro}', complemento_str = '{dados.complemento}', bairro_str = '{dados.bairro}', localidade_str = '{dados.localidade}', " +
                        $"uf_str = '{dados.uf}', ibge_int = {dados.ibge}, gia_int = {dados.gia}, ddd_int = {dados.ddd}, siafi_int = {dados.siafi}, tstamp = current_timestamp " +
                        $"where cep_str = '{dados.cep}'";
            postgresRepository.GenericConnection(query);
        }

        public void deleteData(string cep)
        {
            var query = $"DELETE FROM tabela_ceps " +
                        $"WHERE cep_str = '{cep}'";
            postgresRepository.GenericConnection(query);
        }

        public List<ReturnApiCEPModel> getData(string cep)
        {
            var query = $"SELECT * FROM tabela_ceps " +
                        $"WHERE cep_str = '{cep}'";

            var result = postgresRepository.GetConnection(query);
            
            return result;

        }

        public List<ReturnApiCEPModel> allData(string cep)
        {
            var query = $"SELECT * FROM tabela_ceps";

            var result = postgresRepository.GetConnection(query);

            return result;

        }
    }
}
