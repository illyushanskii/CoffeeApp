using System;
using System.Drawing;
using System.Xml.Linq;

namespace CoffeeApp
{
    public class Product
    {
        private int id;
        private int popularity;
        private string description = "";
        private string name = "";
        private double priceBuy;
        private double priceSell;
        private int quantity;
        private double weight;
        private string type = "";
        private string madeIn = "";
        private string composition = "";
        private string imagePath = "";

        public void ID(int ID){id = ID;}
        public int ID() { return id; }
        public void Popularity(int pop) { popularity = pop; }
        public int Popularity() { return popularity; }
        public void Description(string des) { description = des; }
        public string Description() { return description; }
        public void Name(string nam) { name = nam; }
        public string Name() { return name; }
        public void PriceBuy(double buy) { priceBuy = buy; }
        public double PriceBuy() { return priceBuy; }
        public void PriceSell(double sell) { priceSell = sell; }
        public double PriceSell() { return priceSell; }
        public void Quantity(int qua) { quantity = qua; }
        public int Quantity() { return quantity; }
        public void Weight(double wei) { weight = wei; }
        public double Weight() { return weight; }
        public void Type(string typ) { type = typ; }
        public string Type() { return type; }
        public void MadeIn(string mad) { madeIn = mad; }
        public string MadeIn() { return madeIn; }
        public void Composition(string com) { composition = com; }
        public string Composition() { return composition; }
        public void ImagePath(string path) { imagePath = path; }
        public string ImagePath() { return imagePath; }

        public override string ToString()
        {
            return $"{description}";
        }
    }
}

