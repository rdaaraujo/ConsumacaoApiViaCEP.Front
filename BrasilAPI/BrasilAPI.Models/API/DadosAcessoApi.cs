using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.WebRequestMethods;

namespace BrasilAPI.Models.API
{
    public class DadosAcessoApi
    {
        private static string baseUrl = "https://brasilapi.com.br/api";

        public static string BaseUrl
        {
            get { return baseUrl; }
            private set { baseUrl = value; }
        }
    }
}
