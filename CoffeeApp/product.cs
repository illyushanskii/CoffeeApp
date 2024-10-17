using System;
using System.Drawing;

namespace CoffeeApp
{
    public class Product
    {
        public int Id {get; set;} = -1;
        public int Popularity { get; set; } = 0;
        public string Description { get; set; }
        public string Name {get; set;} = "";
        public double PriceBuy {get; set;} = 0;
        public double PriceSell {get; set;} = 0;
        public int Quantity {get; set;} = 0;
        public double Weight { get; set; } = 0;
        public string CoffeeType {get; set;} = "";
        public string MadeIn {get; set;} = "";
        public string Composition {get; set;} = "";
        public Image Image { get; set; }

        public Product() { 
        
        }
        public override string ToString()
        {
            return $"{Id}){Description}";
        }
    }
}

