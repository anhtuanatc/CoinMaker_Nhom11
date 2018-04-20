using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoinMaker
{
    class Global
    {
        public double total_market_cap_usd { get; set; }
        public double total_24h_volume_usd { get; set; }
        public double bitcoin_percentage_of_market_cap { get; set; }
        public int active_currencies { get; set; }
        public int active_assets { get; set; }
        public int active_markets { get; set; }
        public int last_updated { get; set; }
    }
}
