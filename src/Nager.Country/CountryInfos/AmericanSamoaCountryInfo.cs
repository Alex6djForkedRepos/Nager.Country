using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// American Samoa
    /// </summary>
    public class AmericanSamoaCountryInfo : ICountryInfo
    {
        ///<inheritdoc/>
        public string CommonName => "American Samoa";
        ///<inheritdoc/>
        public string OfficialName => "American Samoa";
        ///<inheritdoc/>
        public string NativeName => "American Samoa";
        ///<inheritdoc/>
        public Alpha2Code Alpha2Code => Alpha2Code.AS;
        ///<inheritdoc/>
        public Alpha3Code Alpha3Code => Alpha3Code.ASM;
        ///<inheritdoc/>
        public int NumericCode => 016;
        ///<inheritdoc/>
        public string[] TLD => new [] { ".as" };

        ///<inheritdoc/>
        public Region Region => Region.Oceania;
        ///<inheritdoc/>
        public SubRegion SubRegion => SubRegion.Polynesia;

        ///<inheritdoc/>
        public Alpha2Code[] BorderCountries => new Alpha2Code[]
        {
        };

        ///<inheritdoc/>
        public ICurrency[] Currencies => new [] { new UsdCurrency() };
        ///<inheritdoc/>
        public string[] CallingCodes => new [] { "1684" };
    }
}
