using CsGoMarketBot.MarketMaster;
using Newtonsoft.Json;
using System;

namespace CsGoMarketBot
{
    internal enum DeserializeType
    {
        BuyForModel,
        DataStatusModel,
        GetStatusModel
    }

    internal class JsonMaster
    {
        public string NormalizeJson(string response)
        {
            var a = JsonConvert.DeserializeObject(response);
            return JsonConvert.SerializeObject(a, Formatting.Indented);
        }

        public T JsonToObject<T>(string response)
        {
            object result;

            var instance1 = new Models.BuyForModel();
            var instance2 = new Models.DataStatusModel();
            var instance3 = new Models.GetStatusModel();

            if (typeof(T) == instance1.GetType())
                result = JsonConvert.DeserializeObject<Models.BuyForModel>(response);
            else if (typeof(T) == instance2.GetType())
                result = JsonConvert.DeserializeObject<Models.DataStatusModel>(response);
            else if (typeof(T) == instance3.GetType())
                result = JsonConvert.DeserializeObject<Models.GetStatusModel>(response);
            else
                result = null;
            return (T)result;
        }
    }

    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.Write("Вставьте секретный ключ CS:GO market: ");
            string secretKey = Console.ReadLine();
            Console.WriteLine();
            IResponseMarket market = new ResponseMarket(secretKey);
            Console.Write("Введите название предмета: ");
            string itemName = Console.ReadLine();
            Console.WriteLine();
            Console.Write("Введите желаему цену в рублях за предмет: ");
            int price = Convert.ToInt32(Console.ReadLine()) * 100;
            Console.WriteLine();//
            Console.Write("Вставьте трейд ссылку получателя предмета: ");
            string tradelink = Console.ReadLine();

            string partner = tradelink.Substring(tradelink.IndexOf("partner"), tradelink.IndexOf("&token") - tradelink.IndexOf("partner"));
            string token = tradelink.Substring(tradelink.IndexOf("token"));
            partner = partner.Substring(partner.IndexOf('=') + 1);
            token = token.Substring(token.IndexOf('=') + 1);

            var response = market.BuyFor(price: price.ToString(), partner: partner, partnerToken: token, hash_name: itemName).Result.Content;

            //JsonMaster для обработки json
            JsonMaster jsonMaster = new JsonMaster();

            Console.WriteLine("********JSON*********");
            Console.WriteLine(jsonMaster.NormalizeJson(response));
            Console.WriteLine();

            //Десериализация в объект
            var answerBuy = jsonMaster.JsonToObject<Models.BuyForModel>(response);
            Console.WriteLine("********OBJECT*******");
            Console.WriteLine($"Success: {answerBuy.Success}");
            Console.WriteLine($"Id: {answerBuy.Id}");
            if (String.IsNullOrEmpty(answerBuy.Price))
                Console.WriteLine($"Price: null");
            else
                Console.WriteLine($"Price: {answerBuy.Price}");
            Console.WriteLine($"Error: {answerBuy.Error}");
            Console.ReadLine();
        }
    }
}