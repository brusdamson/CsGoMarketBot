using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CsGoMarketBot.MarketMaster;
namespace CsGoMarketBot
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Вставьте секретный ключ CS:GO market: ");
            string secretKey = Console.ReadLine();
            Console.WriteLine();
            IResponseMarket market = new ResponseMarket(secretKey);
            Console.Write("Введите название предмета: ");
            string itemName = Console.ReadLine();
            Console.WriteLine();
            Console.Write("Введите желаему цену в рублях за предмет: ");
            int price = Convert.ToInt32(Console.ReadLine())*100;
            Console.WriteLine();//
            Console.Write("Вставьте трейд ссылку получателя предмета: ");
            string tradelink = Console.ReadLine();
            
            string partner = tradelink.Substring(tradelink.IndexOf("partner"), tradelink.IndexOf("&token") - tradelink.IndexOf("partner"));
            string token = tradelink.Substring(tradelink.IndexOf("token"));
            partner = partner.Substring(partner.IndexOf('=')+1);
            token = token.Substring(token.IndexOf('=')+1);

            var response = market.BuyFor(price:price.ToString(),partner:partner,partnerToken:token,hash_name:itemName).Result.Content;
            Console.WriteLine(response);
            Console.ReadLine();

        }
    }
}
