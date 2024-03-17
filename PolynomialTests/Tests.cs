using NUnit.Framework;
using Polynomial;

namespace PolynomialTests
{
    public class Tests
    {
        [TestCase(new int[] { 3, 14, 45 }, new int[] { 3, 14, 45 }, ExpectedResult = true)]
        [TestCase(new int[] { 0, 10, 0 }, new int[] { 0, 11, 0 }, ExpectedResult = false)]
        [TestCase(new int[] { 1, 3, 5, 7 }, new int[] { 1, 2, 4, 4, 5 }, ExpectedResult = false)]
        public Boolean Test_Polinomials_Equals(int[] a, int[] b)
        {
            var firstPolynom = new Polynom(a);
            var secondPolynom = new Polynom(b);
            return firstPolynom == secondPolynom;
        }

        [TestCase(new int[] { 3, 5, 7, 8 }, new int[] { 3, 5, 7, 8 }, ExpectedResult = false)]
        [TestCase(new int[] { 10, 5, 7, 11 }, new int[] { 10, 3, 5, 7, 11 }, ExpectedResult = true)]
        [TestCase(new int[] { 1, 1, 1, 1 }, new int[] { 1, 1, 1, 2 }, ExpectedResult = true)]
        public Boolean Test_Polinomials_Not_Equals(int[] a, int[] b)
        {
            var firstPolynom = new Polynom(a);
            var secondPolynom = new Polynom(b);
            return firstPolynom != secondPolynom;
        }
    }
}