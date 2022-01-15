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
        
        /// <summary>
        /// [id] — id предмета.
        /// [price] — цена в копейках (1 RUB =100, 1 USD = 1000, 1 EUR = 1000) целое число, уже какого-то выставленного лота, 
        /// или можно указать любую сумму больше цены самого дешевого лота, во втором случае будет куплен предмет по самой низкой цене.
        /// partner=[partner]&token=[token] - параметры трейд ссылки аккаунта, который получит предмет.
        /// </summary>
        /// <param name="id">id предмета</param>
        /// <param name="price">Цена в копейках (1 RUB = 100)</param>
        /// <param name="partnerLink"></param>
        /// <returns></returns>
        public async Task<HttpResponseMessage> BuyFor(int idItem, string price, string partner)
        {
            HttpClient client = new HttpClient();
            var dict = new Dictionary<string, string>();
            //Секретный ключ cs go market
            dict.Add("key",_marketSecret);
            //id предмета
            dict.Add("id",idItem.ToString());
            //Цена
            dict.Add("price",price);
            //Кому передать [partner=]&[token=]
            dict.Add("partner",partner);
            return await client.PostAsync(MARKETURL + "buy-for", new FormUrlEncodedContent(dict));
        }
        public async Task<HttpResponseMessage> BuyFor(string price, string partner, string itemHashName)
        {
            HttpClient client = new HttpClient();
            var dict = new Dictionary<string, string>();
            //Секретный ключ cs go market
            dict.Add("key", _marketSecret);
            //Цена
            dict.Add("price", price);
            //Кому передать [partner=]&[token=]
            dict.Add("partner", partner);
            //Название предмета
            dict.Add("market_hash_name", itemHashName);
            return await client.PostAsync(MARKETURL + "buy-for", new FormUrlEncodedContent(dict));
        }
    }
}
