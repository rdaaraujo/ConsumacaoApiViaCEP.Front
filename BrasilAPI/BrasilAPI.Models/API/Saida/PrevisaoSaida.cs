using BrasilAPI.Models.Interfaces;
using BrasilAPI.Models.Models;
using Newtonsoft.Json;
using System.Text.Json.Serialization;

namespace BrasilAPI.Models.API.Saida
{
    internal class PrevisaoSaida : IEstrutura
    {
        [JsonPropertyName("cidade")]
        public string Cidade { get; set; }
        [JsonPropertyName("estado")]
        public string Estado { get; set; }
        [JsonPropertyName("atualizado_em")]
        public DateTime AtualizadoEm { get; set; }
        [JsonPropertyName("clima")]
        public Clima Clima { get; set; }
        public string GetJson() => JsonConvert.SerializeObject(this);
        public object SetJson(string valor) => JsonConvert.DeserializeObject<PrevisaoSaida>(valor);
    }
}
