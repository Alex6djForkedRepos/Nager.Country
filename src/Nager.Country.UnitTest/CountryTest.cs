using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;

namespace Nager.Country.UnitTest
{
    [TestClass]
    public class CountryTest
    {
        [DataTestMethod]
        [DataRow("DE")]
        [DataRow("de")]
        [DataRow("De")]
        [DataRow("dE")]
        [DataRow("DE ")]
        [DataRow(" DE")]
        public void GetCountry(string countryCode)
        {
            ICountryProvider countryProvider = new CountryProvider();

            var countryInfo = countryProvider.GetCountry(countryCode);
            if (countryInfo == null)
            {
                Assert.Fail($"Cannot found countryCode: {countryCode}");
            }
        }

        [DataTestMethod]
        [DataRow("austria")]
        [DataRow("�sterreich")]
        [DataRow("Austria")]
        [DataRow("Republic of Austria")]
        [DataRow("Austrija")]
        [DataRow("Oostenrijk")]
        [DataRow("�sterrike")]
        public void GetCountryByName(string countryName)
        {
            ICountryProvider countryProvider = new CountryProvider();

            var countryInfo = countryProvider.GetCountryByName(countryName);
            Assert.AreEqual(Alpha2Code.AT, countryInfo.Alpha2Code);
        }

        public void GetCountries()
        {
            ICountryProvider countryProvider = new CountryProvider();
            var countries = countryProvider.GetCountries();
            var availableCountryCodes = (Alpha2Code[])Enum.GetValues(typeof(Alpha2Code));

            foreach (var countryCode in availableCountryCodes)
            {
                if (!countries.Any(x => x.Alpha2Code == countryCode))
                {
                    Assert.Fail($"Cannot found a CountryInfo for countryCode: {countryCode}");
                }
            }
        }
    }
}
