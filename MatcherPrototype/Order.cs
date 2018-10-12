using System;

namespace MatcherPrototype
{
    public class Order
    {
        #region Private Declarations

        private Account account = null;

        private decimal price = default(decimal);

        private int quantity = default(int);

        private bool isBuy = true;

        private DateTime orderDate = default(DateTime);

        #endregion Private Declarations

        #region Public Properties

        public Account Account
        {
            get => account;
            set => account = value;
        }

        public decimal Price
        {
            get => price;
            set => price = value;
        }

        public int Quantity
        {
            get => quantity;
            set => quantity = value;
        }

        public bool IsBuy
        {
            get => isBuy;
            set => isBuy = value;
        }

        public DateTime OrderDate
        {
            get => orderDate;
            set => orderDate = value;
        }

        #endregion Public Properties

        #region Constructors

        public Order(Account account, decimal price, int quantity, bool buy)
        {
            Account = account;
            Price = price;
            Quantity = quantity;
            IsBuy = buy;
            OrderDate = DateTime.Now;
        }

        #endregion Constructors

        public Order Clone()
        {
            return (Order)this.MemberwiseClone();
        }



    }
}
