using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsGoMarketBot.Models
{
    internal class BuyForModel : IDefaultModel
    {
        [JsonProperty(PropertyName = "success")]
        public bool Success { get; set; }

        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        [JsonProperty(PropertyName = "price")]
        public string Price { get; set; }

        [JsonProperty(PropertyName = "error")]
        public string Error { get; set; }
        public void AddModelToContainer()
        {
            ModelsContainer.GetInstance().AddModelToContainer(this);
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

    }
}
