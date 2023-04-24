using BrasilAPI.Business.Interfaces;
using BrasilAPI.Models.API;
using BrasilAPI.Models.Enums;
using RestSharp;

namespace BrasilAPI.Business.Control
{
    public class ConectaApiControl : IConectaApiControl
    {
        public RestResponse Conecta(MetodoAPI metodoAPI, object Entrada, Method method)
        {
            var urlBase = DadosAcessoApi.BaseUrl;
            var uri = new Uri(urlBase, UriKind.Absolute);
            var url = uri.AbsoluteUri + metodoAPI.ToString().ToLower();

            var api = new RestClient(url);

            var request = new RestRequest(url, method);

            var response = api.Execute(request);

            return response;

        }
    }
}
