namespace Nager.Country.Currencies
{
    /// <summary>
    /// Sll Currency
    /// </summary>
    public sealed class SllCurrency : ICurrency
    {
        /// <inheritdoc/>
        public string? Symbol => "Le";

        /// <inheritdoc/>
        public string? Singular => "leone";

        /// <inheritdoc/>
        public string? Plural => "leones";

        /// <inheritdoc/>
        public string IsoCode => "SLL";

        /// <inheritdoc/>
        public string NumericCode => "694";

        /// <inheritdoc/>
        public string Name => "Sierra Leonean leone";
    }
}
