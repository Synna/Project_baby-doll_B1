using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ExoPoupeesRA;
using System.Diagnostics;


namespace TestEtape6
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestPrixOk()
        {
            try
            {
                BoiteMusique boite1 = new BoiteMusique(75, 50, "France", 1980, "Classique", 1, 180);
            }
            catch(PrixTropBasException)
            {
                Assert.Fail();
            }
        }

        [TestMethod]
        public void TestPrixTropBas()
        {
            try
            {
                BoiteMusique boite1 = new BoiteMusique(75, 50, "France", 1980, "Classique", 1, 10);
            }
            catch (PrixTropBasException)
            {
            }
            catch(Exception)
            {
                Assert.Fail();
            }
        }

        [TestMethod]
        public void TestObjetDeCollection()
        {
            ViewModel.laCollection.Clear();
            BoiteMusique boite1 = new BoiteMusique(75, 50, "France", 1980, "Classique", 1, 180);
            Poupee Mary83 = new Poupee("Mary", 83, 70, Poupee.sexe.femme, 15, "Ecosse", 1853);

            Assert.AreEqual(2, ViewModel.laCollection.Count);
        }


    }
}
