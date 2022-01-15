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
        
        
    }
}
