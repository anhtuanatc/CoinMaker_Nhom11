using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Connect
{
    class ModelChartCoin
    {
        public Double price_usd { get; set; }
        public Double last_updated { get; set; }


        public ModelChartCoin(Double usd, Double dateTime)
        {
            price_usd = usd;
            last_updated = dateTime;

        }

    }
}
