using CsGoMarketBot.Models;
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
            
            foreach (var item in ModelsContainer.GetInstance().GetModelsContainer())
            {
                if (typeof(T) == item.GetType())
                {
                    result = JsonConvert.DeserializeObject<T>(response);
                    return (T)result;
                }
            }
            return default(T);
        }
    }
}
