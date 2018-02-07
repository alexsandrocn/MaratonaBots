using Newtonsoft.Json;

namespace MaratonaBots.Models
{

    public class Resultado
    {
        public Cotacao[] Cotacoes { get; set; }
    }

    public class Cotacao
    {
        [JsonProperty("nome")]

        public string Nome { get; set; }

        [JsonProperty("sigla")]

        public string Sigla { get; set; }

        [JsonProperty("valor")]

        public float Valor { get; set; }
    }


}