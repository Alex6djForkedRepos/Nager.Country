namespace Nager.Country.Currencies
{
    public class RubCurrency : ICurrency
    {
        public string Symbol => "₽";

        public string Singular => null;

        public string Plural => null;

        public string IsoCode => "RUB";

        public string NumericCode => null;

        public string Name => "Russian Ruble";
    }
}
