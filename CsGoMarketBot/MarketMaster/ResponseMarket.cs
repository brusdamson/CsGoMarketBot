using RestSharp;
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
        private readonly string MARKETURL;
        public ResponseMarket(string marketSecret)
        {
            _marketSecret = marketSecret;
            MARKETURL = $"https://market.csgo.com/api/v2/buy-for?key={_marketSecret}";
        }

        public async Task<RestResponse> BuyFor(string price, string partner, string partnerToken, string hash_name)
        {
            var client = new RestClient(MARKETURL + $"&hash_name={hash_name}&price={price}&partner={partner}&token={partnerToken}");
            var req = new RestRequest();
            return await client.PostAsync(req);
        }
    }
}
