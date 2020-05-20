using Back.Api.SampleRestSharp.Interface;
using Back.Api.SampleRestSharp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RestSharp;

using Newtonsoft.Json;

namespace Back.Api.SampleRestSharp.Service
{
    
    public class CepService : ICepService
    {
        private readonly IRestClient _client;

        public CepService(IRestClient client)
        {
            client.BaseUrl = new Uri("https://viacep.com.br/");
            client.AddDefaultHeader("ApiToken", "Token");
            _client = client;
        }
        public Address GetAddressByCep(string cep)
        { 
            var restRequest = new RestRequest($"/ws/{cep}/json/",Method.GET);
            restRequest.AddHeader("x-api-key","barrer {tokenJWT}");
            restRequest.AddParameter("nome", "valor", ParameterType.QueryString);

            var teste = _client.Execute(restRequest);
            return  JsonConvert.DeserializeObject<Address>(teste.Content);
        }
    }
}
