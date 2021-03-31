namespace Nager.Country.Currencies
{
    public class KrwCurrency : ICurrency
    {
        ///<inheritdoc/>
        public string Symbol => "₩";

        ///<inheritdoc/>
        public string Singular => null;

        ///<inheritdoc/>
        public string Plural => null;

        ///<inheritdoc/>
        public string IsoCode => "KRW";

        ///<inheritdoc/>
        public string NumericCode => "410";

        ///<inheritdoc/>
        public string Name => "South Korean Won";
    }
}
