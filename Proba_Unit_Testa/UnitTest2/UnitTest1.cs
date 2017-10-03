using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Proba_Unit_Testa;


namespace UnitTest2
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestInicijalizacijeNovogRacuna()
        {
            Racun r1 = new Racun();
            Assert.IsNotNull(r1);
        }

        [TestMethod]
        public void TestPocetnogStanja()
        {
            Racun r2 = new Racun();
            double stanje = r2.Stanje;
            Assert.AreEqual(stanje, 0);
        }

        [TestMethod]
        public void TestUplateNovca()
        {   
            //provera obicne uplate
            Racun r3 = new Racun();
            bool uplata = r3.UplatiNovacNaRacun(100.00);
            Assert.IsTrue(uplata);
            
            //provera negativne uplate
            uplata = r3.UplatiNovacNaRacun(-100);
            Assert.IsFalse(uplata);

            //provera stanja posle uplate
            double stanje3 = r3.Stanje;
            Assert.AreEqual(stanje3, 100);
        }
        [TestMethod]
        public void TestSkidanjaNovca()
        {
            //provera obicnog skidanja sa racuna
            Racun r4 = new Racun(150);
            bool skidanje = r4.SkiniNovacSaRacuna(50);
            Assert.IsTrue(skidanje);

            //provera skidanja svote vece od stanja na racunu
            bool skidanje2 = r4.SkiniNovacSaRacuna(200);
            Assert.IsFalse(skidanje2);

            //provera negativnog skidanja sa racuna
            bool skidanje3 = r4.SkiniNovacSaRacuna(-50);
            Assert.IsFalse(skidanje3);

            //provera stanja posle uplate
            double stanje4 = r4.Stanje;
            Assert.AreEqual(stanje4, 100);
        }
    }
}