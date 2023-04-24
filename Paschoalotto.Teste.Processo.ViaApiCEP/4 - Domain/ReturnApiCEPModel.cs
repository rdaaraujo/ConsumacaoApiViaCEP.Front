using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4___Domain
{
    public class ReturnApiCEPModel
    {
            public string? cep { get; set; }
            public string? logradouro { get; set; }
            public string? complemento { get; set; }
            public string? bairro { get; set; }
            public string? localidade { get; set; }
            public string? uf { get; set; }
            public int? ibge { get; set; }
            public int? gia { get; set; }
            public int? ddd { get; set; }
            public int? siafi { get; set; }
    }
}
