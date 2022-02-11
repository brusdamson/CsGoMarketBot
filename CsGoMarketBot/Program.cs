using CsGoMarketBot.JsonTransducer;
using CsGoMarketBot.MarketMaster;
using System;

namespace CsGoMarketBot
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.Write("Вставьте секретный ключ CS:GO market: ");
            string secretKey = Console.ReadLine();
            Console.WriteLine();
            IResponseMarket market = new ResponseMarket(secretKey);

            //Метод GetMoney
            var response = market.GetMoney().Result.Content;
            
            //JsonMaster для обработки json
            JsonMaster jsonMaster = new JsonMaster();

            Console.WriteLine("********JSON*********");
            Console.WriteLine(jsonMaster.NormalizeJson(response));
            Console.WriteLine();

            //Десериализация в объект
            var answerGetMoney = jsonMaster.JsonToObject<Models.GetMoneyModel>(response);
            Console.WriteLine("********OBJECT*******");
            Console.WriteLine($"Success: {answerGetMoney.Success}");
            Console.WriteLine($"Currency: {answerGetMoney.Currency}");
            Console.WriteLine($"Balance: {answerGetMoney.Money}");
            Console.ReadLine();
        }
    }
}