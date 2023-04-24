using BrasilAPI.Models.Enums;
using System.Net;

namespace BrasilAPI.Business.Interfaces
{
    internal interface IFluxoApiControl
    {
        (object Retorno, HttpStatusCode statusCode) ProcessaDados(MetodoAPI metodoAPI, object Entrada, object Retorno);
    }
}
