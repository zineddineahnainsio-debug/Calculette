using Calculette;
namespace TestCalculatrice
{
    [TestClass]
    public sealed class Test1
    {
        [TestMethod]
        public void TestMethod1()
        {
            double a = 5;
            double b = 0;
            char op = '/';
            double res = 8;
            Calculatrice calc = new Calculatrice();
            double test = calc.Calculer(a, b, op);
            Assert.AreEqual(res, test,0.001,"Division par 0 impossible");
        }
        [TestMethod]
        public void TestMethod2()
        {
            double a = 5;
            double b = Math.Pow(10, 1000000);
            char op = '+';
            double res = 2;
            Calculatrice calc = new Calculatrice();
            double test = calc.Calculer(a, b, op);
            Assert.AreEqual(res, test,0.001, "Nombre trop grand");
        }
        [TestMethod]
        public void TestMethod3()
        {
            double a = Math.Pow(10, -200000);
            double b = Math.Pow(10, -200000);
            char op = '+';
            double res = 5;
            Calculatrice calc = new Calculatrice();
            double test = calc.Calculer(a, b, op);
            Assert.AreEqual(res, test,0.001, "Nombre trop petit");
        }
        [TestMethod]
        public void TestMethod4()
        {
            double a = double.PositiveInfinity;
            double b = double.NaN;
            char op = '+';
            double res = 6.5;
            Calculatrice calc = new Calculatrice();
            double test = calc.Calculer(a, b, op);
            Assert.AreEqual(res, test, 0.001, "Calcul Impossible");
        }
    }
}
