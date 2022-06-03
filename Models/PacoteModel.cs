using Newtonsoft.Json;
namespace Pingou.Models
{
    public class PacoteModel
    {
        [JsonProperty("codigo")]
        public string Codigo { get; set; }

        [JsonProperty("host")]
        public string Host { get; set; }

        [JsonProperty("eventos")]
        public List<Evento> Eventos { get; set; }

        [JsonProperty("quantidade")]
        public int Quantidade { get; set; }

        [JsonProperty("servico")]
        public string Servico { get; set; }

    }

    public class Evento
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("local")]
        public string Local { get; set; }

        [JsonProperty("data")]
        public string Data { get; set; }

        [JsonProperty("hora")]
        public string Hora { get; set; }
    }
}