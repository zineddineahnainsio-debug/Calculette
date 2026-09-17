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
            char op = '$';
            double res = 8;
            Calculatrice calc = new Calculatrice();
            double test = calc.Calculer(a, b, op);
            Assert.AreEqual(res, test);
        }
        [TestMethod]
        public void TestMethod2()
        {
            double a = 5;
            double b = null;
            char op = '+';
            double res = 2;
            Calculatrice calc = new Calculatrice();
            double test = calc.Calculer(a, b, op);
            Assert.AreEqual(res, test);
        }
        [TestMethod]
        public void TestMethod3()
        {
            double a = 5.9;
            double b = 5.9. ;
            char op = '+';
            double res = 5;
            Calculatrice calc = new Calculatrice();
            double test = calc.Calculer(a, b, op);
            Assert.AreEqual(res, test);
        }
    }
}
