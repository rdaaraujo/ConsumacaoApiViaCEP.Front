using BrasilAPI.Models.Interfaces;
using Newtonsoft.Json;
using System.Text.Json.Serialization;

namespace BrasilAPI.Models.API.Saida
{
    public class LocalidadeSaida : IEstrutura
    {
        [JsonPropertyName("nome")]
        public string Nome { get; set; }
        [JsonPropertyName("id")]
        public int ID { get; set; }
        [JsonPropertyName("estado")]
        public string Estado { get; set; }
        public string GetJson() => JsonConvert.SerializeObject(this);
        public object SetJson(string valor) => JsonConvert.DeserializeObject<LocalidadeSaida>(valor);
    }
}
