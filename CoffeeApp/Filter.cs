using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeApp
{
    public class Filter
    {
        public string Name { get; set; } = "";
        public double PriceStart { get; set; } = 0;
        public double PriceFinish { get; set; } = 0;
        public double WeightStart { get; set; } = 0;
        public double WeightFinish { get; set; } = 0;
        public string CoffeeType { get; set; } = "";
        public string MadeIn { get; set; } = "";
        public string Composition { get; set; } = "";

        public Filter()
        {

        }
    }
}
