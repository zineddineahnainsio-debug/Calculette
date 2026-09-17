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
            double b = 4.889;
            char op = '/';
            double res = 8;
            Calculatrice calc = new Calculatrice();
            double test = calc.Calculer(a, b, op);
            Assert.AreEqual(res, test);
        }
        [TestMethod]
        public void TestMethod2()
        {
            double a = 5.3 ;
            double b = 2.6;
            char op = '+';
            double res = 2;
            Calculatrice calc = new Calculatrice();
            double test = calc.Calculer(a,b,op);
            Assert.AreEqual(res, test);
        }
        
    }
}
