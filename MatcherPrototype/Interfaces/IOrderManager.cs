﻿using MatcherPrototype.Enumerators;
using System.Collections.Generic;

namespace MatcherPrototype.Interfaces
{
    public interface IOrderManager
    {
        /// <summary>
        /// List of all orders placed.
        /// </summary>
        IList<IOrder> OrderHistory { get; set; }

        /// <summary>
        /// List of available orders in the market place.
        /// </summary>
        IList<IOrder> MarketOrders { get; set; }

        /// <summary>
        /// List of aggregate orders at a particular price.
        /// </summary>
        IList<IOrderGroup> AggregateOrders { get; set; }

        /// <summary>
        /// List of cumulative orders at a particular price.
        /// </summary>
        IList<IOrderGroup> CumulativeOrders { get; set; }

        /// <summary>
        /// Find a match for the order.
        /// </summary>
        /// <param name="newOrder">The order to match.</param>
        /// <returns>A matching order if it exists.</returns>
        IOrder MatchOrder(IOrder order);

        /// <summary>
        /// Place the order.
        /// </summary>
        /// <param name="account">The account of the new order.</param>
        /// <param name="quantity">The quantity of the new order.</param>
        /// <param name="price">The price of the new order.</param>
        /// <param name="orderType">The order type of the new order.</param>
        /// <returns>A list of trades generated by the new order.</returns>
        IList<ITrade> PlaceOrder(IAccount account, int quantity, decimal price, OrderType orderType);

        /// <summary>
        /// Place the order.
        /// </summary>
        /// <param name="newOrder">The new order to place.</param>
        /// <returns>A list of trades generated by the new order.</returns>
        IList<ITrade> PlaceOrder(IOrder newOrder);

    }
}