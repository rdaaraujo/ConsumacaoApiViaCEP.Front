using BrasilAPI.Models.Enums;
using RestSharp;

namespace BrasilAPI.Business.Interfaces
{
    public interface IConectaApiControl
    {
        RestResponse Conecta(MetodoAPI metodoAPI, object Entrada, Method method);
    }
}
