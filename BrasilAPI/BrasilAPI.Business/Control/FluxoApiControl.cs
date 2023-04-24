using BrasilAPI.Business.Interfaces;
using BrasilAPI.Models.Enums;
using Nancy.Json;
using System.Net;

namespace BrasilAPI.Business.Control
{
    public class FluxoApiControl : IFluxoApiControl
    {
        public (object Retorno, HttpStatusCode statusCode) ProcessaDados(MetodoAPI metodoAPI, object Entrada, object Retorno)
        {
            try
            {
                dynamic result = null;
                var retornoConect = new ConectaApiControl();

                var retorno = retornoConect.Conecta(metodoAPI, Entrada, RestSharp.Method.Get);
                var content = retornoConect.Conecta(metodoAPI, Entrada, RestSharp.Method.Get).Content;

                if (!string.IsNullOrEmpty(content))
                {
                    var jss = new JavaScriptSerializer();

                    result = jss.Deserialize<dynamic>(content);

                    return (result, retorno.StatusCode);
                }

                return ("", HttpStatusCode.BadRequest);
            }
            catch (Exception ex)
            {
                return ("{Erro :" + ex.Message + "}", HttpStatusCode.InternalServerError);
            }
        }
    }
}
