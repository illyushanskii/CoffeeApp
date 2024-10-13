using System;
using System.Drawing;

namespace CoffeeApp
{
    class Product
    {
        public int Id {get; set;}
        public string Coffee {get; set;} = "";
        public double DeliveryPrice {get; set;}
        public double SalePrice {get; set;}
        public int Amount {get; set;}
        public double Mass {get; set;}
        public string CoffeeType {get; set;} = "";
        public string MadeIn {get; set;} = "";
        public string Composition {get; set;} = "";
        public Image Image {get; set;}
    }
}

