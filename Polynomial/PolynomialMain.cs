namespace Polynomial
{
    public class PolynomialMain
    {
        public static void Main(string[] args)
        {
            var firstPolinomial = new Polynom(new int[] { 3, 6, 9, 12 });
            var secPolynomial = new Polynom(new int[] { 3, 6, 9, 12 });
            Console.WriteLine(firstPolinomial == secPolynomial);

            firstPolinomial = new Polynom(new int[] { 1, 3, 5 });
            secPolynomial = new Polynom(new int[] { 2, 4, 6 });
            Console.WriteLine(firstPolinomial != secPolynomial);
        }
    }
}