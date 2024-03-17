namespace FloatConverter
{
    /// <summary>
    /// Provides functionality to convert a floating-point number to its binary representation.
    /// </summary>
    public class FloatToBinaryConverter
    {
        /// <summary>
        /// Converts float number to its binary representation.
        /// </summary>
        /// <param name="number">Float number to convert.</param>
        /// <returns>String that represents binary representation of float number</returns>
        public static string ConvertToBinary(float number)
        {
            var bits = BitConverter.SingleToInt32Bits(number);
            var binaryChars = new char[32];

            for (var i = 0; i < 32; i++)
            {
                var shiftedNumber = bits >> (31 - i);
                binaryChars[i] = (shiftedNumber & 1) == 1 ? '1' : '0';
            }

            return new string(binaryChars);
        }
    }
}