using NUnit.Framework;
using FloatConverter;

namespace FloatConverterTests
{
    public class Tests
    {
        [TestCase(4.55f, "01000000100100011001100110011010")]
        [TestCase(-111.11f, "11000010110111100011100001010010")]
        [TestCase(0.00033f, "00111001101011010000001111011010")]
        [TestCase(-90.0f, "11000010101101000000000000000000")]
        [TestCase(0.0f, "00000000000000000000000000000000")]
        [TestCase(float.MinValue, "11111111011111111111111111111111")]
        [TestCase(float.MaxValue, "01111111011111111111111111111111")]
        public void ConvertToBinary_When_Input_Float_Number_Return_Actual_Result(float number, string expectedResult)
        {
            string actualResult = FloatToBinaryConverter.ConvertToBinary(number);
            Assert.That(expectedResult, Is.EqualTo(actualResult));
        }
    }
}