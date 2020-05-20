using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Back.Api.SampleRestSharp.Model
{
    public class Address
    {
        [JsonProperty("cep")]
        public string Cep { get; set; }
        [JsonProperty("logradouro")]
        public string Endereco { get; set; }
        [JsonProperty("complemento")]
        public string Complemento { get; set; }
        public string Bairro { get; set; }
        public string Localidade { get; set; }
        public string Uf { get; set; }
        public string Unidade { get; set; }
        public string Ibge { get; set; }
        public string Gia { get; set; }
    }
}
