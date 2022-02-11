using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsGoMarketBot.Models
{
    internal class DataStatusModel:IDefaultModel
    {
        [JsonProperty(PropertyName = "item_id")]
        public int Item_Id { get; set; }

        [JsonProperty(PropertyName ="market_hash_name")]
        public string Market_Hash_Name { get; set; }

        [JsonProperty(PropertyName = "classid")]
        public int ClassId { get; set; }

        [JsonProperty(PropertyName = "instance")]
        public int Instance { get; set; }

        [JsonProperty(PropertyName = "time")]
        public int Time { get; set; }

        [JsonProperty(PropertyName = "send_until")]
        public string Send_Until { get; set; }

        [JsonProperty(PropertyName = "stage")]
        public int Stage { get; set; }

        [JsonProperty(PropertyName = "paid")]
        public decimal Paid { get; set; }

        [JsonProperty(PropertyName = "causer")]
        public string Causer { get; set; }

        [JsonProperty(PropertyName = "currency")]
        public string Currency { get; set; }

        [JsonProperty(PropertyName = "for")]
        public string For { get; set; }

        [JsonProperty(PropertyName = "trade_id")]
        public string Trade_Id { get; set; }

        public void AddModelToContainer()
        {
            ModelsContainer.GetInstance().AddModelToContainer(this);
        }
    }
}
