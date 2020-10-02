using Microsoft.VisualStudio.TestTools.UnitTesting;
using Fahrzeugpark;

namespace UnitTest_Fahrzeugpark
{
    [TestClass]
    public class PKW_Test
    {
        //UNIT-TESTS sind kleinteilige Software-Tests, welche jeweils zum Testen einer einzige Funktion gedacht sind. Ausgeführt werden sie
        ///über den Test-Explorer
        [TestMethod]
        public void Beschleunige_PKW_ueber_MaxG()
        {
            PKW pkw1 = new PKW("BMW", 230, 25000, 5);

            pkw1.StarteMotor();
            pkw1.Beschleunige(pkw1.MaxGeschwindigkeit + 1);

            //Dies ASSERT-Klasse enthält diverse Vergleichsmethoden, welche in Unit-Tests verwendet werden können. Pro Test-Methode
            ///muss es mindesten einen Assert-Aufruf geben
            Assert.AreEqual(pkw1.MaxGeschwindigkeit, pkw1.AktGeschwindigkeit);
        }

        [TestMethod]
        public void Bremse_PKW_unter_0()
        {
            PKW pkw1 = new PKW("BMW", 230, 25000, 5);

            pkw1.StarteMotor();
            pkw1.Beschleunige(-1);

            Assert.AreEqual(0, pkw1.AktGeschwindigkeit);
        }
    }
}
