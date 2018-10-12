using System;
using System.Collections.Generic;

namespace MatcherPrototype
{
    public class Matcher
    {
        #region Private Declarations

        private List<Order> orderHistory = null;

        private List<Order> marketOrders = null;

        private List<Trade> tradeList = null;

        private List<Account> accounts = null;

        #endregion Private Declarations

        #region Public Properties

        public List<Order> OrderHistory
        {
            get => orderHistory ?? (orderHistory = new List<Order>());
            set => orderHistory = value;
        }

        public List<Account> Accounts
        {
            get => accounts ?? (Accounts = new List<Account>());
            set => accounts = value;
        }

        public List<Order> MarketOrders
        {
            get => marketOrders ?? (marketOrders = new List<Order>());
            set => marketOrders = value;
        }

        public List<Trade> TradeList
        {
            get => tradeList ?? (tradeList = new List<Trade>());
            set => tradeList = value;
        }

        #endregion Public Properties

        #region Methods

        #region Account

        public Account GetAccount(int accountNumber)
        {
            return FindAccount(accountNumber) != null ? FindAccount(accountNumber) : CreateAccount(accountNumber);
        }

        private Account FindAccount(int accountNumber)
        {
            return Accounts.Find(x => x.AccountNumber == accountNumber);
        }

        public Account CreateAccount(int accountNumber, string name)
        {
            return new Account(accountNumber, name);
        }

        public Account CreateAccount(int accountNumber)
        {
            return new Account(accountNumber);
        }

        #endregion Account

        #region Order

        public void PlaceOrder(int accountNumber, decimal price, int quantity, bool buy)
        {
            ProcessOrder(CreateOrder(GetAccount(accountNumber), price, quantity, buy));
        }

        private Order CreateOrder(Account account, decimal price, int quantity, bool isBuy)
        {
            return new Order(account, price, quantity, isBuy);
        }

        private void ProcessOrder(Order newOrder)
        {
            OrderHistory.Add(newOrder.Clone());

            int quantity = newOrder.Quantity;

            while (quantity > 0)
            {
                Order existingOrder = MatchOrder(newOrder);

                if (existingOrder != null)
                {
                    quantity = ProcessTrade(newOrder, existingOrder);
                }
                else
                {
                    MarketOrders.Add(newOrder);
                    break;
                }
            }
        }

        private Order MatchOrder(Order newOrder)
        {
            foreach (var order in MarketOrders.FindAll(x => x.IsBuy != newOrder.IsBuy))
            {
                if (newOrder.IsBuy)
                {
                    if (order.Price <= newOrder.Price)
                    {
                        return order;
                    }
                }
                else
                {
                    if (order.Price >= newOrder.Price)
                    {
                        return order;
                    }
                }
            }

            return null;
        }

        #endregion Order

        #region Trade

        private Trade CreateTrade(Account buyer, Account seller, int quantity, decimal price)
        {
            return new Trade(buyer, seller, quantity, price);
        }

        private Account GetTradeAccount(Order newOrder, Order existingOrder, bool buyer)
        {
            return newOrder.IsBuy == buyer ? newOrder.Account : existingOrder.Account;
        }

        private int ProcessTrade(Order newOrder, Order existingOrder)
        {
            if (newOrder.Quantity < existingOrder.Quantity)
            {
                existingOrder.Quantity -= newOrder.Quantity;

                TradeList.Add(CreateTrade(GetTradeAccount(newOrder, existingOrder, true), GetTradeAccount(newOrder, existingOrder, false), newOrder.Quantity, existingOrder.Price));

                //Return zero as no more items to match.
                return 0;
            }
            else
            {
                newOrder.Quantity -= existingOrder.Quantity;
                MarketOrders.Remove(existingOrder);

                TradeList.Add(CreateTrade(GetTradeAccount(newOrder, existingOrder, true), GetTradeAccount(newOrder, existingOrder, false), existingOrder.Quantity, existingOrder.Price));

                return newOrder.Quantity;
            }
        }

        #endregion Trade


        #endregion Methods



    }
}
