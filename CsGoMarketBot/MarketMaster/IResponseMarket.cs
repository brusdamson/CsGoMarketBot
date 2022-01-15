using RestSharp;
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
        Task<RestResponse> BuyFor(string price, string partner, string partnerToken, string hash_name);
        Task<RestResponse> GetStatusById(string custom_id);
    }
}
