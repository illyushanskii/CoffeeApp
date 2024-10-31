using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeApp
{
    public class Filter
    {
        private string name;
        private double priceStart;
        private double priceFinish;
        private double weightStart;
        private double weightFinish;
        private string type;
        private string madeIn;
        private string composition;

        public Filter(){}
        public void Name(string nam){ name = nam; }
        public string Name() { return name; }
        public void PriceStart(double start) { priceStart = start; }
        public double PriceStart() { return priceStart; }
        public void PriceFinish(double finish) { priceFinish = finish; }
        public double PriceFinish() { return priceFinish; }
        public void WeightStart(double start) { weightStart = start; }
        public double WeightStart() { return weightStart; }
        public void WeightFinish(double finish) { weightFinish = finish; }
        public double WeightFinish() { return weightFinish; }
        public void Type(string typ) { type = typ; }
        public string Type() { return type; }
        public void MadeIn(string made) { madeIn = made; }
        public string MadeIn() { return madeIn; }
        public void Composition(string com) { composition = com; }
        public string Composition() { return composition; }
    }
}
