﻿using MatcherPrototype.Classes;
using MatcherPrototype.Enumerators;
using MatcherPrototype.Interfaces;
using System;
using System.Windows.Forms;

namespace MatcherPrototype
{
    public partial class Form1 : Form
    {
        private IMatcher matcher = null;

        public IMatcher Matcher
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
            Matcher.PlaceOrder(textBoxAccountNumber.Text, int.Parse(textBoxAmount.Text), decimal.Parse(textBoxPrice.Text), radioButtonBuy.Checked ? OrderType.BUY : OrderType.SELL);

            RefreshTrades();
            RefreshOrderHistory();
            RefreshMarketOrders();
        }

        private void RefreshTrades()
        {
            textBoxTrades.Clear();

            foreach (var item in Matcher.TradeManager.MarketTrades)
            {
                textBoxTrades.Text += item.Quantity + "@ £" + item.Price + ":£" + item.Value + " Buyer:" + item.Buyer.AccountNumber + " Seller: " + item.Seller.AccountNumber;
                textBoxTrades.Text += Environment.NewLine;
            }
        }

        private void RefreshOrderHistory()
        {
            textBoxOrderHistory.Clear();

            foreach (var item in Matcher.OrderManager.OrderHistory)
            {
                textBoxOrderHistory.Text += item.OrderDate.Value.ToLongTimeString() + " => ";
                textBoxOrderHistory.Text += item.OrderType == OrderType.BUY ? "BUY => " : "SELL => ";
                textBoxOrderHistory.Text += item.Quantity + "@ £" + item.Price;
                textBoxOrderHistory.Text += Environment.NewLine;
            }
        }

        private void RefreshMarketOrders()
        {
            textBoxMarketOrders.Clear();

            foreach (var item in Matcher.OrderManager.MarketOrders)
            {
                textBoxMarketOrders.Text += item.OrderDate.Value.ToLongTimeString() + " => ";
                textBoxMarketOrders.Text += item.OrderType == OrderType.BUY ? "BUY => " : "SELL => ";
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
