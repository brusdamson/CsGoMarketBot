using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace CsGoMarketBot.MarketMaster
{
    internal class ResponseMarket : IResponseMarket
    {
        private readonly string _marketSecret;
        private const string MARKETURL = "https://market.csgo.com/api/v2/";
        public ResponseMarket(string marketSecret)
        {
            _marketSecret = marketSecret;
        }

        {
            HttpClient client = new HttpClient();
            var dict = new Dictionary<string, string>();
            dict.Add("key",_marketSecret);
            dict.Add("price",price);
            dict.Add("partner",partner);
            return await client.PostAsync(MARKETURL + "buy-for", new FormUrlEncodedContent(dict));
        }
    }
}
