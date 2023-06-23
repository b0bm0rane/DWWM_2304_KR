using CL_Voiture;

namespace TP_Voiture
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethodVoitureDemarrer()
        {
            Voiture caisseASavon = new Voiture();
            bool ok = caisseASavon.Demarrer();
            Assert.IsTrue(ok);
        }

        // Clic-droit sur TP -> Exécuter les tests

        [TestMethod]
        public void TestMethodVoitureEteindre()
        {
            Voiture caisseASavon = new Voiture();
            caisseASavon.Demarrer();
            bool ok = caisseASavon.Eteindre();
            Assert.IsTrue(ok);
        }

        [TestMethod]
        public void TestMethodVoitureEteindreDejaEteint()
        {
            Voiture caisseASavon = new Voiture();
            bool ok = caisseASavon.Eteindre();
            Assert.IsFalse(ok);
        }

        [TestMethod]
        public void TestMethodRoueStop()
        {

            Voiture caisseASavon = new Voiture();
            bool ok = caisseASavon.Freiner();
            Assert.IsFalse(ok);

        }
    }
}