using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeApp
{
    public class Cart
    {
        private int productId;
        private int productQuantity;
        private string description = "";
        private int quantity;
        private double priceBuy;
        private double priceSell;
        private string imagePath = "";
        private int popularity;

        public void ProductId(int ID) { productId = ID; }
        public int ProductId() { return productId; }
        public void Popularity(int pop) { popularity = pop; }
        public int Popularity() { return popularity; }
        public void ProductQuantity(int qua) { productQuantity = qua; }
        public int ProductQuantity() { return productQuantity; }
        public void Description(string des) { description = des; }
        public string Description() { return description; }
        public void PriceBuy(double buy) { priceBuy = buy; }
        public double PriceBuy() { return priceBuy; }
        public void PriceSell(double sell) { priceSell = sell; }
        public double PriceSell() { return priceSell; }
        public void Quantity(int qua) { quantity = qua; }
        public int Quantity() { return quantity; }
        public void ImagePath(string path) { imagePath = path; }
        public string ImagePath() { return imagePath; }
    }
}
