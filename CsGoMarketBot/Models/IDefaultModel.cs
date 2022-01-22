using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsGoMarketBot.Models
{
    internal interface IDefaultModel : IDisposable
    {
        void AddModelToContainer();
    }
}
