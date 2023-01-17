using System;
using System.Collections.Generic;
using System.Text;

namespace Country_And_States_Telephone_Codes
{
    public static class CountryCodes
    {

        public static string GetACountryCode(string country)
        {
            country = country.ToLower();

            var data = CountryAndPhoneCodeData.ListOfCountriesAndCodes();

            string code;
            try
            {
                return code = "+" + data[country];
            }
            catch(KeyNotFoundException ex)
            {
                return ex.Message;
            }
        }

        public static StringBuilder GetCountries()
        {
            var data = CountryAndPhoneCodeData.ListOfCountriesAndCodes();

            StringBuilder listOfCountries = new StringBuilder();

            foreach(string country in data.Keys)
            {
                listOfCountries.Append(country + "\n");
            }
            return listOfCountries;
        }
    }
}

