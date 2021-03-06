namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;

    public class SubscriptionItemPriceDataOptions : INestedOptions
    {
        /// <summary>
        /// Three-letter ISO currency code, in lowercase. Must be a supported currency.
        /// </summary>
        [JsonProperty("currency")]
        public string Currency { get; set; }

        /// <summary>
        /// The ID of the product that this price will belong to.
        /// </summary>
        [JsonProperty("product")]
        internal string Product { get; set; }

        /// <summary>
        /// The recurring components of a price such as its interval.
        /// </summary>
        [JsonProperty("recurring")]
        public SubscriptionItemPriceDataRecurringOptions Recurring { get; set; }

        /// <summary>
        /// The amount in cents to be charged on the interval specified.
        /// </summary>
        [JsonProperty("unit_amount")]
        public long? UnitAmount { get; set; }

        /// <summary>
        /// Same as <see cref="UnitAmount"/>, but contains a decimal value with at most 12 decimal
        /// places.
        /// </summary>
        [JsonProperty("unit_amount_decimal")]
        public decimal? UnitAmountDecimal { get; set; }
    }
}
