namespace Calculette
{
    public class Calculatrice
    {
        public double Addition(double a,double b)
        {
            return a + b;
        }
        public double Soustraction(double a, double b)
        {
            return a - b;
        }
        public double Multiplication(double a, double b)
        {
            return a * b;
        }
        public double Division(double a, double b)
        {
            if (b == 0)
            {
                throw new DivideByZeroException("Division par zero impossible");
            }
            return a / b;
        }
        public double Calculer(double a, double b, char operateur) 
        {
            return operateur switch
            {
                '+' => Addition(a, b),
                '-' => Soustraction(a, b),
                '*' => Multiplication(a, b),
                '/' => Division(a, b),
                _ => throw new ArgumentException($"Opérateur non supporté: {operateur}")

            };
        }
    }
}
