using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsGoMarketBot.Models
{
    internal class GetStatusModel
    {
        public bool Success { get; set; }
        public IEnumerable<DataStatusModel> Data { get; set; }
    }
}
