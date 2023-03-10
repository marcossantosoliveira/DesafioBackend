using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace DesafioBackend.Integrations.CotacaoMoedas
{
    public class CotacaoMoedasClient : ICotacaoMoedasClient
    {
        public async Task<CotacaoMoedaUSDBRLDto> ObterCotacaoMoedaUSD()
        {
            var request = new HttpRequestMessage(HttpMethod.Get, $"https://economia.awesomeapi.com.br/json/last/USD-BRL");

            using (var client = new HttpClient())
            {
                var response = await client.SendAsync(request);
                var contentResp = await response.Content.ReadAsStringAsync();
                var objResp = JsonConvert.DeserializeObject<CotacaoMoedaUSDBRLDto>(contentResp);

                if (response.IsSuccessStatusCode)
                {
                    return objResp;
                }

                return objResp;
            }
        }

        public async Task<CotacaoMoedaBRLUSDDto> ObterCotacaoMoedaBRL()
        {
            var request = new HttpRequestMessage(HttpMethod.Get, $"https://economia.awesomeapi.com.br/json/last/BRL-USD");

            using (var client = new HttpClient())
            {
                var response = await client.SendAsync(request);
                var contentResp = await response.Content.ReadAsStringAsync();
                var objResp = JsonConvert.DeserializeObject<CotacaoMoedaBRLUSDDto>(contentResp);

                if (response.IsSuccessStatusCode)
                {
                    return objResp;
                }

                return objResp;
            }
        }
    }
}
