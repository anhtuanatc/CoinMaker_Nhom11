using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Connect
{
    class Model
    {
        public string id { get; set; }
        public string name { get; set; }
        public string rank { get; set; }
        public string price_usd { get; set; }
        public string price_btc { get; set; }
        public string market_cap_usd { get; set; }
        public string last_updated { get; set; }
    }
}
