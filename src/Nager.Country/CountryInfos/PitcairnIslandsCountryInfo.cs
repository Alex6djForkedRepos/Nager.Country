using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Pitcairn Islands
    /// </summary>
    public class PitcairnIslandsCountryInfo : ICountryInfo
    {
        /// <inheritdoc/>
        public string CommonName => "Pitcairn Islands";
        /// <inheritdoc/>
        public string OfficialName => "Pitcairn Group of Islands";
        /// <inheritdoc/>
        public string NativeName => "Pitcairn Islands";
        /// <inheritdoc/>
        public Alpha2Code Alpha2Code => Alpha2Code.PN;
        /// <inheritdoc/>
        public Alpha3Code Alpha3Code => Alpha3Code.PCN;
        /// <inheritdoc/>
        public int NumericCode => 612;
        /// <inheritdoc/>
        public string[] TLD => new [] { ".pn" };

        /// <inheritdoc/>
        public Region Region => Region.Oceania;
        /// <inheritdoc/>
        public SubRegion SubRegion => SubRegion.Polynesia;

        /// <inheritdoc/>
        public Alpha2Code[] BorderCountries => new Alpha2Code[]
        {
        };

        /// <inheritdoc/>
        public ICurrency[] Currencies => new [] { new NzdCurrency() };
        /// <inheritdoc/>
        public string[] CallingCodes => new [] { "64" };
    }
}
