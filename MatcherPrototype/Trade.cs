using System;

namespace MatcherPrototype
{
    public class Trade
    {

        #region Private Declarations

        private Account buyer = null;

        private Account seller = null;

        private int quantity = default(int);

        private decimal price = default(decimal);

        private decimal value = default(decimal);

        #endregion Private Declarations

        #region Public Properties

        public Account Buyer
        {
            get => buyer ?? throw new NullReferenceException("Buyer has not been set");
            set => buyer = value;
        }

        public Account Seller
        {
            get => seller;
            set => seller = value;
        }

        public int Quantity
        {
            get => quantity;
            set => quantity = value;
        }

        public decimal Price
        {
            get => price;
            set => price = value;
        }

        public decimal Value
        {
            get => value == default(decimal) ? value = price * quantity : value;
            set => this.value = value;
        }

        #endregion Public Properties

        #region Constructor

        public Trade(Account buyer, Account seller, int quantity, decimal price)
        {
            Buyer = buyer;
            Seller = seller;
            Quantity = quantity;
            Price = price;
        }

        #endregion Constructor

    }
}
