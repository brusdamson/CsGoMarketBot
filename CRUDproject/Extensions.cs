using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mongo.Core;
using MongoDB.Driver;

namespace CRUDproject
{
    public static class Extensions
    {
        public static T LoadRecordsByName<T>(this MongoCRUD mongo, string itemName, string table, IMongoDatabase db)
        {
            var collection = db.GetCollection<T>(table);
            var filter = Builders<T>.Filter.Eq("ItemTitle",itemName);
            try
            {
                return collection.Find(filter).First();
            }
            catch (Exception)
            {

                return default(T);//
            }
           

        }
        
    }
}
