using FlexibleExchangeRate.Core.Model;
using Refit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlexibleExchangeRate.Core.NbpApi
{
    public interface INbpApi
    {
        [Get("/exchangerates/tables/{table}/")]
        Task<NbpTable[]> GetTable(string table);
    }
}
