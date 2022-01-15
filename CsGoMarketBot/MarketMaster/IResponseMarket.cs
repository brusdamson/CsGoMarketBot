using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace CsGoMarketBot.MarketMaster
{
    internal interface IResponseMarket
    {
        Task<HttpResponseMessage> BuyFor(int idItem, string price, string partner);
    }
}
