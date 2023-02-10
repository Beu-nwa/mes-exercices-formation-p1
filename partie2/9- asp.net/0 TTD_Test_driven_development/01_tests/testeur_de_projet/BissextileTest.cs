using projet_a_tester;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testeur_de_projet
{
    [TestClass]
    public class BissextileTest
    {
        private Annee annee;

        [TestMethod]
        public void Test_Bissextile_4000_sould_be_false()
        {
            annee = new Annee(4000);
            bool r = annee.IsBissextile();
            Assert.IsTrue(r);
        }
        [TestMethod]
        public void Test_Bissextile_400_sould_be_true()
        {
            annee = new Annee(400);
            bool r = annee.IsBissextile();
            Assert.IsTrue(r);
        }
        [TestMethod]
        public void Test_Bissextile_4_not_100_sould_be_true()
        {
            annee = new Annee(4);
            bool r = annee.IsBissextile();
            Assert.IsTrue(r);
            //Assert.AreEqual("26", result); // pour les tests de methodes string
        }

        [TestMethod]
        public void Test_Bissextile_1999_sould_be_false()
        {
            annee = new Annee(1999);
            bool r = annee.IsBissextile();
            Assert.IsTrue(r);
            //Assert.AreEqual("26", result); // pour les tests de methodes string
        }

    }
}
