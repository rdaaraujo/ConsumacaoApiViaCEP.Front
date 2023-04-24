namespace BrasilAPI.Models.Models
{
    internal class Previsao
    {
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public DateTime AtualizadoEm { get; set; }
        public Clima Clima { get; set; }
    }
}
