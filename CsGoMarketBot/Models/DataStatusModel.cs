using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsGoMarketBot.Models
{
    internal class DataStatusModel
    {
        public int Item_Id { get; set; }
        public string Market_Hash_Name { get; set; }
        public int ClassId { get; set; }
        public int Instance { get; set; }
        public int Time { get; set; }
        public string Send_Until { get; set; }
        public int Stage { get; set; }
        public decimal Paid { get; set; }
        public string Causer { get; set; }
        public string Currency { get; set; }
        public string For { get; set; }
        public string Trade_Id { get; set; } 
    }
}
