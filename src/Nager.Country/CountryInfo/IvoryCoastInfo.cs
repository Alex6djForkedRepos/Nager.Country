namespace Nager.Country.CountryInfo
{
	/// <summary>
	/// Ivory Coast
	/// </summary>
	public class IvoryCoastInfo : ICountryInfo
	{
		public string CommonName => "Ivory Coast";
		public string OfficialName => "Republic of Côte d'Ivoire";

		public Alpha2Code Alpha2Code => Alpha2Code.CI;
		public Alpha3Code Alpha3Code => Alpha3Code.CIV;
		public int NumericCode => 384;
		public string[] TLD => new [] { ".ci" };

		public Region Region => Region.Africa;
		public SubRegion SubRegion => SubRegion.WesternAfrica;

		public Alpha2Code[] BorderCountrys => new Alpha2Code[]
		{
			Alpha2Code.BF,
			Alpha2Code.GH,
			Alpha2Code.GN,
			Alpha2Code.LR,
			Alpha2Code.ML,
		};

		public string[] Currencies => new [] { "XOF" };
		public string[] CallingCodes => new [] { "225" };
	}
}
