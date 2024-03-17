namespace Polynomial
{
    /// <summary>
    /// Represents a polynomial with int coefficients.
    /// </summary>
    public class Polynom
    {
        private int[] coefficients;

        /// <summary>
        /// Initializes a new instance of the <see cref="Polynom"/> class with the specified coefficients.
        /// </summary>
        /// <param name="coefficients">The coefficients of the polynomial.</param>
        public Polynom(int[] coefficients)
        {
            this.coefficients = coefficients;
        }

        /// <summary>
        /// Determines whether two polynomials are equal.
        /// </summary>
        public static Boolean operator ==(Polynom a, Polynom b)
        {
            return IsCoefficientsEqual(a.coefficients, b.coefficients);
        }

        /// <summary>
        /// Determines whether two polynomials are not equal.
        /// </summary>
        public static Boolean operator !=(Polynom a, Polynom b)
        {
            return !IsCoefficientsEqual(a.coefficients, b.coefficients);
        }

        /// <summary>
        ///  Determines whether coefficients of two polynomials are equal
        /// </summary>
        private static bool IsCoefficientsEqual(int[] coefficientsA, int[] coefficientsB)
        {
            if (coefficientsA.Length != coefficientsB.Length) return false;
            for (var i = 0; i < coefficientsA.Length; i++)
            {
                if (coefficientsA[i] != coefficientsB[i]) return false;
            }

            return true;
        }
    }
}