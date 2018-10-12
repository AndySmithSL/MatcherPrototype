using System;

namespace MatcherPrototype.Interfaces
{
    public interface IOrder
    {
        /// <summary>
        /// The account of the order
        /// </summary>
        Account Account { get; set; }
       
        /// <summary>
        /// The price of the order
        /// </summary>
        decimal Price { get; set; }

        /// <summary>
        /// The quantity of the order
        /// </summary>
        int Quantity { get; set; }

        /// <summary>
        /// Is the order a buy .....note could use an enum here.
        /// </summary>
        bool IsBuy { get; set; }

        /// <summary>
        /// The date and time of the order
        /// </summary>
        DateTime OrderDate { get; set; }

        /// <summary>
        /// Clone the order
        /// </summary>
        /// <returns>Return a copy of the order.</returns>
        IOrder Clone();
     
    }
}
