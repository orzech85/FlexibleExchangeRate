using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlexibleExchangeRate.Core.Model
{

    public class NbpTable
    {
        public string table { get; set; }
        public string no { get; set; }
        public string effectiveDate { get; set; }
        public Rate[] rates { get; set; }
    }

    public class Rate
    {
        public string currency { get; set; }
        public string code { get; set; }
        public float mid { get; set; }
    }
}
