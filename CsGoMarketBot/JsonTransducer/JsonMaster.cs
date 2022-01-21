using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsGoMarketBot.JsonTransducer
{
    /// <summary>
    /// Класс для обработки ответов в виде Json
    /// </summary>
    internal class JsonMaster
    {
        /// <summary>
        /// Преобразует в удобночитаемый вид Json
        /// </summary>
        /// <param name="response"></param>
        /// <returns></returns>
        public string NormalizeJson(string response)
        {
            var a = JsonConvert.DeserializeObject(response);
            return JsonConvert.SerializeObject(a, Formatting.Indented);
        }
        /// <summary>
        /// Метод использующий обобщение для универсального преобразования ответа Json в объект по соответствующей модели
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="response"></param>
        /// <returns></returns>
        public T JsonToObject<T>(string response)
        {
            object result;
            List<object> list = new List<object>();
            
            var instance1 = new Models.BuyForModel();
            var instance2 = new Models.DataStatusModel();
            var instance3 = new Models.GetStatusModel();
            var instance4 = new Models.GetMoneyModel();

            list.Add(instance1);
            list.Add(instance2);
            list.Add(instance3);
            list.Add(instance4);

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
}
