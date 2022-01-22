using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsGoMarketBot.Models
{
    internal class ModelsContainer
    {
        private static List<object> modelsList;
        private static ModelsContainer _instance;

        //Конструктор защищен модификатором private. Реализация паттерна Singletone
        private ModelsContainer()
        {

        }
        public static ModelsContainer GetInstance()
        {
            if (_instance == null)
                _instance = new ModelsContainer();
            return _instance;
        }
        public List<object> GetModelsContainer()
        {
            //Добавлять новые модели тут. Каждая модель должна наследоваться от IDefaultModel
            new BuyForModel().AddModelToContainer();
            new DataStatusModel().AddModelToContainer();
            new GetMoneyModel().AddModelToContainer();
            new GetStatusModel().AddModelToContainer();
            return modelsList;
        }
        public void AddModelToContainer<T>(T model)
        {
            if (modelsList == null)
                modelsList = new List<object>();
            modelsList.Add(model);
        }
    }
}
