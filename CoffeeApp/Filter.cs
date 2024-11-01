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

        public static void Filtering(Filter filter, List<Product> Products, List<Product> Filtred, System.Windows.Forms.ToolStripButton btn, string textSearch, string sort)
        {
            if (filter != null)
            {
                btn.Checked = true;
                Filtred.Clear();
                string none = "none";
                for (int i = 0; i < Products.Count; i++)
                {
                    Product prod = Products[i];
                    bool check = true;
                    if (prod.Name() != filter.Name() && filter.Name() != none) { check = false; }
                    if (prod.Composition() != filter.Composition() && filter.Composition() != none) { check = false; }
                    if (prod.Type() != filter.Type() && filter.Type() != none) { check = false; }
                    if (prod.MadeIn() != filter.MadeIn() && filter.MadeIn() != none) { check = false; }
                    if (prod.PriceSell() < filter.PriceStart() || prod.PriceSell() > filter.PriceFinish()) { check = false; }
                    if (prod.Weight() < filter.WeightStart() || prod.Weight() > filter.WeightFinish()) { check = false; }
                    if (check)
                    {
                        Filtred.Add(prod);
                    }
                }
            }
            else
            {
                btn.Checked = false;
                Filtred.Clear();
                foreach (Product item in Products)
                {
                    Filtred.Add(item);
                }
            }
            if (!string.IsNullOrWhiteSpace(textSearch) && textSearch != "Пошук...")
            {
                Searching(Filtred, textSearch);
            }
            Sorting(Filtred, sort);
        }
        private static void Sorting(List<Product> Filtred, string sort)
        {
            Comparison<Product> comparison = null;

            switch (sort)
            {
                case "pop":
                    comparison = (x, y) => y.Popularity().CompareTo(x.Popularity());
                    break;
                case "nam":
                    comparison = (x, y) => string.Compare(x.Name(), y.Name());
                    break;
                case "chp":
                    comparison = (x, y) => x.PriceSell().CompareTo(y.PriceSell());
                    break;
                case "exp":
                    comparison = (x, y) => y.PriceSell().CompareTo(x.PriceSell());
                    break;
                default:
                    MessageBox.Show("Error sorting");
                    return;
            }

            if (comparison != null)
            {
                Filtred.Sort(comparison);
            }
        }
        private static void Searching(List<Product> Filtred, string textSearch)
        {
            List<Product> searchProducts = new List<Product>();
            string search = textSearch.ToLower();
            foreach (Product product in Filtred)
            {
                if (product.Description().ToLower().Contains(search))
                {
                    searchProducts.Add(product);
                }
            }
            Filtred.Clear();
            foreach (Product item in searchProducts)
            {
                Filtred.Add(item);
            }

        }

    }
}
