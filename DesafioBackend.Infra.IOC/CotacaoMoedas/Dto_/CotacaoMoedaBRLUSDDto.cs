using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesafioBackend.Integrations.CotacaoMoedas
{
    public class CotacaoMoedaBRLUSDDto
    {
        public BRLUSD BRLUSD { get; set; }
    }

    public class BRLUSD
    {
        [JsonProperty(PropertyName = "code")]
        public string Code { get; set; }

        [JsonProperty(PropertyName = "codein")]
        public string Codein { get; set; }

        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        [JsonProperty(PropertyName = "high")]
        public decimal High { get; set; }

        [JsonProperty(PropertyName = "low")]
        public decimal Low { get; set; }

        [JsonProperty(PropertyName = "varBid")]
        public decimal VarBid { get; set; }

        [JsonProperty(PropertyName = "pctChange")]
        public decimal PctChange { get; set; }

        [JsonProperty(PropertyName = "bid")]
        public decimal Bid { get; set; }

        [JsonProperty(PropertyName = "ask")]
        public decimal Ask { get; set; }

        [JsonProperty(PropertyName = "timestamp")]
        public long Timestamp { get; set; }

        [JsonProperty(PropertyName = "create_date")]
        public DateTime Create_date { get; set; }
    }

}
