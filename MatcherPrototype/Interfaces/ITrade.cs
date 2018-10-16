namespace MatcherPrototype.Interfaces
{
    public interface ITrade
    {
        /// <summary>
        /// Account of the Buyer
        /// </summary>
        IAccount Buyer { get; set; }

        /// <summary>
        /// Account of the Seller
        /// </summary>
        IAccount Seller { get; set; }

        /// <summary>
        /// Quantity of the trade
        /// </summary>
        int Quantity { get; set; }

        /// <summary>
        /// Price of the trade
        /// </summary>
        decimal Price { get; set; }

        /// <summary>
        /// Overall value of the trade.
        /// </summary>
        decimal Value { get; set; }

    }
}
