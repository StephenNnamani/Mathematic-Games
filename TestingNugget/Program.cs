using System;
using System.Collections.Generic;
using System.Text;

namespace TestingNugget
{
    internal class Program
    {
        public static void Main()
        {
            Country_And_States_Telephone_Codes.CountryCodes countryCodes = new Country_And_States_Telephone_Codes.CountryCodes();

            var test = countryCodes.GetCountryCodes("Nigeria");

            Console.WriteLine(test);
        }
    }
}
