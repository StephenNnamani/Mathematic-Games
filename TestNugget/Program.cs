using Country_And_States_Telephone_Codes;

namespace TestNugget
{
    public class Program
    {
        public static void Main()
        {
            CountryCodes countryCodes = new CountryCodes();

            string result = countryCodes.GetCountryCodes("Nigeria");

            Console.WriteLine(result);
        }
    }
}