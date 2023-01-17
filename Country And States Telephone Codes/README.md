
# Countries and Their Telephone Codes

This nugget package is targeted at reducing the stress of 
sourcing, typing countries and their telephone codes. The nugget 
package contains a generic Dictionary collection of 243 countries, and their
Telephone codes.




## Built With

- Major languages: C#
- Frameworks: .NET Standard 2.0
- Technologies: Github and Visual Studio
- Source of data is https://countrycode.org/
- Live Demo
- Live Demo Link


## Getting Started

### _To install our package using the .NET CLI_
- run: 'dotnet add package CountryAndTheirTelephoneCodes --version 1.0.3'

### _Installation using Visual Studio_
- Right-click on project dependencies
- Select manage Nuget packages
- Search CountryAndTheirTelephoneCodes
- Click install
## Prerequisites
- An understanding of C# 
- Usage of NuGet Packages in .Net
- A Visual Studio
# Usage
NOTE:   They are all a static method
### _Getting the complete Dictionary List of Countries and their telephone codes._
```C#
using CountryAndTheirTelephoneCodes;
namespace TestingCode
{
    internal class Program
    {
        static void Main(string[] args)
        { 
          AllCountriesAndPhoneCodes();
        }

        private static void AllCountriesAndPhoneCodes()
        {
           Dictionary<string, string> listOfCountriesAndCodes = CountryAndPhoneCodeData.CountryAndPhoneCodeDataMethod();
           
           foreach(KeyValuePair<string, string> country in listOfCountriesAndCodes)
           {
                Console.WriteLine($"Country: {country.Keys} Phone Code: {country.Values}");
           }
        }
    }
}
```
### _Getting the code of a country by typing the name of the country_
```C#
using CountryAndTheirTelephoneCodes;
namespace TestingCode
{
    internal class Program
    {
        static void Main(string[] args)
        { 
          GetACountryCode();
        }

        private static void GetACountryCode()
        {
           string Code = CountryCodes.GetACountryCode("Nigeria");
           
           Console.WriteLine(Code);
        }
    }
}
```
### _Getting Names of Countries returned as a StringBuilder._
```C#
using CountryAndTheirTelephoneCodes;
namespace TestingCode
{
    internal class Program
    {
        static void Main(string[] args)
        {
          // Note they are mostly a static class
          
          GetCountryNames();
        }

        private static void GetCountryNames()
        {
           StringBuilder namesOfCountries = CountryCodes.GetCountries();
           Console.WriteLine(namesOfCountries);
        }
    }
}
```
# Authors
👤 Nnamani Stephen Obumnaeme


## 🚀 About Me
I'm a full stack developer...

- .Net Framework
- ASP.Net Core
- Angular
- HTML
- CSS
- BootStrap
- MaterialUI
## 🔗 Links
[![Github](https://img.shields.io/badge/my_portfolio-000?style=for-the-badge&logo=ko-fi&logoColor=white)](https://github.com/StephenNnamani/)
[![linkedin](https://img.shields.io/badge/linkedin-0A66C2?style=for-the-badge&logo=linkedin&logoColor=white)](https://www.linkedin.com/in/StephenNnamani)
[![twitter](https://img.shields.io/badge/twitter-1DA1F2?style=for-the-badge&logo=twitter&logoColor=white)](https://twitter.com/stephenscripts)


## Support

For support, email sir.stephennnamani@gmail.com


## License

[MIT](https://choosealicense.com/licenses/mit/)


## Contributing

Contributions are always welcome!

Email me s.nnamani@genesystechhub.com to get started.

Please adhere to this project's `code of conduct`.

