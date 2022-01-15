using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CsGoMarketBot.MarketMaster;
using Newtonsoft.Json;
namespace CsGoMarketBot
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Отправляет запрос на покупку предмета с последующей передачей
            ResponseMarket market = new ResponseMarket("6O0AmJoyZCU62j18b4KcV51e0DSIKiO");
            var response = market.BuyFor("10000", "848145993", "CVsrQmKW", "'Blueberries' Buckshot | NSWC SEAL").Result;
            string json = response.Content;
            object a = JsonConvert.DeserializeObject(json);
            string b = JsonConvert.SerializeObject(a, Formatting.Indented);
            Console.WriteLine(b);
            Console.ReadLine();
        }
    }
}
