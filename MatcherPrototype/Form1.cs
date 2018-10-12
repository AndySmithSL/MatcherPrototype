using System;
using System.Windows.Forms;

namespace MatcherPrototype
{
    public partial class Form1 : Form
    {
        private Matcher matcher = null;

        public Matcher Matcher
        {
            get => matcher ?? (matcher = new Matcher());
            set => matcher = value;
        }

        public Form1()
        {
            InitializeComponent();

            RefreshTrades();
            RefreshOrderHistory();
            RefreshMarketOrders();
        }

        private void radioButtonBuy_CheckedChanged(object sender, EventArgs e)
        {
            radioButtonSell.Checked = !radioButtonBuy.Checked;
        }

        private void radioButtonSell_CheckedChanged(object sender, EventArgs e)
        {
            radioButtonBuy.Checked = !radioButtonSell.Checked;
        }

        private void buttonPlaceOrder_Click(object sender, EventArgs e)
        {
            Matcher.PlaceOrder(int.Parse(textBoxAccountNumber.Text), decimal.Parse(textBoxPrice.Text), int.Parse(textBoxAmount.Text), radioButtonBuy.Checked);

            RefreshTrades();
            RefreshOrderHistory();
            RefreshMarketOrders();
        }

        private void RefreshTrades()
        {
            textBoxTrades.Clear();

            foreach (var item in Matcher.TradeList)
            {
                textBoxTrades.Text += item.Quantity + "@ £" + item.Price + ":£" + item.Value + " Buyer:" + item.Buyer.AccountNumber + " Seller: " + item.Seller.AccountNumber;
                textBoxTrades.Text += Environment.NewLine;
            }
        }

        private void RefreshOrderHistory()
        {
            textBoxOrderHistory.Clear();

            foreach (var item in Matcher.OrderHistory)
            {
                textBoxOrderHistory.Text += item.OrderDate.ToLongTimeString() + " => ";
                textBoxOrderHistory.Text += item.IsBuy ? "BUY => " : "SELL => ";
                textBoxOrderHistory.Text += item.Quantity + "@ £" + item.Price;
                textBoxOrderHistory.Text += Environment.NewLine;
            }
        }

        private void RefreshMarketOrders()
        {
            textBoxMarketOrders.Clear();

            foreach (var item in Matcher.MarketOrders)
            {
                textBoxMarketOrders.Text += item.OrderDate.ToLongTimeString() + " => ";
                textBoxMarketOrders.Text += item.IsBuy ? "BUY => " : "SELL => ";
                textBoxMarketOrders.Text += item.Quantity + "@ £" + item.Price;
                textBoxMarketOrders.Text += Environment.NewLine;
            }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            matcher = new Matcher();

            RefreshTrades();
            RefreshOrderHistory();
            RefreshMarketOrders();
        }
    }
}
