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
            MARKETURL = $"https://market.csgo.com/api/v2/";
        }

        /// <summary>
        /// Покупает предмет с последующей передачей
        /// </summary>
        /// <param name="price"></param>
        /// <param name="partner"></param>
        /// <param name="partnerToken"></param>
        /// <param name="hash_name"></param>
        /// <returns></returns>
        public async Task<RestResponse> BuyFor(string price, string partner, string partnerToken, string hash_name)
        {
            var client = new RestClient(MARKETURL + $"buy-for?key={_marketSecret}" + $"&hash_name={hash_name}&price={price}&partner={partner}&token={partnerToken}");
            var req = new RestRequest();
            return await client.PostAsync(req);
        }
        /// <summary>
        /// Возвращает текущий баанс аккаунта
        /// </summary>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public async Task<RestResponse> GetMoney()
        {
            var client = new RestClient(MARKETURL+ $"get-money?key={_marketSecret}");
            var req = new RestRequest();
            return await client.PostAsync(req);
        }

        public async Task<RestResponse> GetStatusById(string custom_id)
        {
            var client = new RestClient(MARKETURL+$"&custom_id={custom_id}");
            var req = new RestRequest();
            return await client.PostAsync(req);
        }
    }
}
