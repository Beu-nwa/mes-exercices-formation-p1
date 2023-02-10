using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projet_a_tester._05_shop
{
    public class Shop
    {
        private List<Product> products;
        public List<Product> Products { get => products; set => products = value; }

        public Shop()
        {
            products = new List<Product>();
        }
        public int Update(Product p)
        {
            int coef = 1;
            if (p.SellIn > 0)
            {
                p.SellIn--;
            }
            else
            {
                coef++;
            }

            if (p.Type == "produit laitier")
            {
                coef *= 2;
            }

            p.Quality += p.Name == "brie vieilli" ? coef : -coef;

            p.Quality = p.Quality >= 0 && p.Quality <= 50 ? p.Quality : p.Quality <= 50 ? 0 : 50;

            return p.Quality;
        }
    }
}
