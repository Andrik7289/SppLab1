namespace FloatConverter
{
    public class ConverterMain
    {
        public static void Main(string[] args)
        {
            var floatNumber = float.Parse(Console.ReadLine());
            Console.WriteLine($"Binary format of {floatNumber} = {FloatToBinaryConverter.ConvertToBinary(floatNumber)}");
        }
    }
}