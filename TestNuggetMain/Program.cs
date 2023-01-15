using Country_And_States_Telephone_Codes;

namespace TestNuggetMain
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string result = CountryCodes.GetACountryCode("Nigeria");
            Console.WriteLine(result);
        }
    }
}