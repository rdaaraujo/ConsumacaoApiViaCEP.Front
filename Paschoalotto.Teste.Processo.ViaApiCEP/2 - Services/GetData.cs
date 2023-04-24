using _4___Domain;
using Newtonsoft.Json;
using System.Net;

namespace Services
{
    public class GetData
    {
        public ReturnApiCEPModel ApiCEPGet(string cep)
        {
            var request = (HttpWebRequest)WebRequest.Create($"https://viacep.com.br/ws/{cep}/json/");
            request.Method = "GET";

            var response = (HttpWebResponse)request.GetResponse();

            var streamReader = new StreamReader(response.GetResponseStream());
            var responseText = streamReader.ReadToEnd();

            var responseJson = JsonConvert.DeserializeObject<ReturnApiCEPModel>(responseText);

            Console.WriteLine(responseText);

            return responseJson;
        }   
    }
}
