using projet_a_tester;
using projet_a_tester._05_shop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testeur_de_projet._05_shop
{
    [TestClass]
    public class ShopTest
    {
        //private List<Product> products= new List<Product>();
        private Shop shop = new Shop();

        [TestMethod]
        public void Quality_test_cant_be_under_0_should_be_true()
        {
            Assert.AreEqual(0, shop.Update(new Product("fruit", "fraise", 5, 0)));
        }

        [TestMethod]
        public void Quality_test_over_0_and_sellIn_over_0_should_be_decrease_by_1_and_true()
        {
            Assert.AreEqual(7, shop.Update(new Product("fruit", "fraise", 5, 8)));
        }

        [TestMethod]
        public void Quality_test_over_0_and_sellIn_at_0_should_be_decrease_by_2_and_true()
        {
            Assert.AreEqual(10, shop.Update(new Product("legume", "panais", 0, 12)));
        }

        [TestMethod]
        public void Quality_test_brieVieillit_over_0_and_sellIn_at_0_should_be_increase_by_4_and_true()
        {
            Assert.AreEqual(44, shop.Update(new Product("produit laitier", "brie vieilli", 0, 40)));
        }

        [TestMethod]
        public void Quality_test_cant_be_over_50_should_be_true()
        {
            Assert.AreEqual(50, shop.Update(new Product("produit laitier", "brie vieilli", 0, 49)));
        }


    }
}
