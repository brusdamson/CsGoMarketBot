using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsGoMarketBot.Models
{
    internal class GetMoneyModel
    {
        [JsonProperty(PropertyName = "money")]
        public decimal Money { get; set; }

        [JsonProperty(PropertyName = "currency")]
        public string Currency { get; set; }

        [JsonProperty(PropertyName = "success")]
        public bool Success { get; set; }
    }
}
