using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Botswana
    /// </summary>
    public sealed class BotswanaCountryInfo : ICountryInfo
    {
        /// <inheritdoc/>
        public string CommonName => "Botswana";

        /// <inheritdoc/>
        public string OfficialName => "Republic of Botswana";

        /// <inheritdoc/>
        public string NativeName => "Botswana";

        /// <inheritdoc/>
        public Alpha2Code Alpha2Code => Alpha2Code.BW;

        /// <inheritdoc/>
        public Alpha3Code Alpha3Code => Alpha3Code.BWA;

        /// <inheritdoc/>
        public int NumericCode => 072;

        /// <inheritdoc/>
        public string[] TLD => [".bw"];

        /// <inheritdoc/>
        public Region Region => Region.Africa;

        /// <inheritdoc/>
        public SubRegion SubRegion => SubRegion.SouthernAfrica;

        /// <inheritdoc/>
        public Alpha2Code[] BorderCountries =>
        [
            Alpha2Code.NA,
            Alpha2Code.ZA,
            Alpha2Code.ZM,
            Alpha2Code.ZW,
        ];

        /// <inheritdoc/>
        public ICurrency[] Currencies => [new BwpCurrency()];

        /// <inheritdoc/>
        public string[] CallingCodes => ["267"];
    }
}
