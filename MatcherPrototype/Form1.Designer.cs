namespace MatcherPrototype
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonPlaceOrder = new System.Windows.Forms.Button();
            this.groupBoxOrderForm = new System.Windows.Forms.GroupBox();
            this.labelPrice = new System.Windows.Forms.Label();
            this.labelAmount = new System.Windows.Forms.Label();
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            this.textBoxAmount = new System.Windows.Forms.TextBox();
            this.radioButtonSell = new System.Windows.Forms.RadioButton();
            this.radioButtonBuy = new System.Windows.Forms.RadioButton();
            this.groupBoxLastTrade = new System.Windows.Forms.GroupBox();
            this.labelLastTradeResult = new System.Windows.Forms.Label();
            this.labelSellerValue = new System.Windows.Forms.Label();
            this.labelSeller = new System.Windows.Forms.Label();
            this.labelBuyerValue = new System.Windows.Forms.Label();
            this.labelBuyer = new System.Windows.Forms.Label();
            this.textBoxOrderHistory = new System.Windows.Forms.TextBox();
            this.textBoxMarketOrders = new System.Windows.Forms.TextBox();
            this.labelOrderHistory = new System.Windows.Forms.Label();
            this.labelMarket = new System.Windows.Forms.Label();
            this.textBoxTrades = new System.Windows.Forms.TextBox();
            this.labelTrades = new System.Windows.Forms.Label();
            this.buttonClear = new System.Windows.Forms.Button();
            this.textBoxAccountNumber = new System.Windows.Forms.TextBox();
            this.labelAccount = new System.Windows.Forms.Label();
            this.groupBoxOrderForm.SuspendLayout();
            this.groupBoxLastTrade.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonPlaceOrder
            // 
            this.buttonPlaceOrder.Location = new System.Drawing.Point(114, 127);
            this.buttonPlaceOrder.Name = "buttonPlaceOrder";
            this.buttonPlaceOrder.Size = new System.Drawing.Size(75, 23);
            this.buttonPlaceOrder.TabIndex = 0;
            this.buttonPlaceOrder.Text = "Place Order";
            this.buttonPlaceOrder.UseVisualStyleBackColor = true;
            this.buttonPlaceOrder.Click += new System.EventHandler(this.buttonPlaceOrder_Click);
            // 
            // groupBoxOrderForm
            // 
            this.groupBoxOrderForm.Controls.Add(this.labelAccount);
            this.groupBoxOrderForm.Controls.Add(this.textBoxAccountNumber);
            this.groupBoxOrderForm.Controls.Add(this.labelPrice);
            this.groupBoxOrderForm.Controls.Add(this.labelAmount);
            this.groupBoxOrderForm.Controls.Add(this.textBoxPrice);
            this.groupBoxOrderForm.Controls.Add(this.textBoxAmount);
            this.groupBoxOrderForm.Controls.Add(this.radioButtonSell);
            this.groupBoxOrderForm.Controls.Add(this.radioButtonBuy);
            this.groupBoxOrderForm.Controls.Add(this.buttonPlaceOrder);
            this.groupBoxOrderForm.Location = new System.Drawing.Point(12, 12);
            this.groupBoxOrderForm.Name = "groupBoxOrderForm";
            this.groupBoxOrderForm.Size = new System.Drawing.Size(200, 163);
            this.groupBoxOrderForm.TabIndex = 1;
            this.groupBoxOrderForm.TabStop = false;
            this.groupBoxOrderForm.Text = "Order Form";
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.Location = new System.Drawing.Point(7, 94);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(31, 13);
            this.labelPrice.TabIndex = 6;
            this.labelPrice.Text = "Price";
            // 
            // labelAmount
            // 
            this.labelAmount.AutoSize = true;
            this.labelAmount.Location = new System.Drawing.Point(7, 68);
            this.labelAmount.Name = "labelAmount";
            this.labelAmount.Size = new System.Drawing.Size(43, 13);
            this.labelAmount.TabIndex = 5;
            this.labelAmount.Text = "Amount";
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.Location = new System.Drawing.Point(56, 91);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.Size = new System.Drawing.Size(133, 20);
            this.textBoxPrice.TabIndex = 4;
            // 
            // textBoxAmount
            // 
            this.textBoxAmount.Location = new System.Drawing.Point(56, 65);
            this.textBoxAmount.Name = "textBoxAmount";
            this.textBoxAmount.Size = new System.Drawing.Size(133, 20);
            this.textBoxAmount.TabIndex = 3;
            // 
            // radioButtonSell
            // 
            this.radioButtonSell.AutoSize = true;
            this.radioButtonSell.Location = new System.Drawing.Point(89, 19);
            this.radioButtonSell.Name = "radioButtonSell";
            this.radioButtonSell.Size = new System.Drawing.Size(42, 17);
            this.radioButtonSell.TabIndex = 2;
            this.radioButtonSell.Text = "Sell";
            this.radioButtonSell.UseVisualStyleBackColor = true;
            this.radioButtonSell.CheckedChanged += new System.EventHandler(this.radioButtonSell_CheckedChanged);
            // 
            // radioButtonBuy
            // 
            this.radioButtonBuy.AutoSize = true;
            this.radioButtonBuy.Checked = true;
            this.radioButtonBuy.Location = new System.Drawing.Point(15, 19);
            this.radioButtonBuy.Name = "radioButtonBuy";
            this.radioButtonBuy.Size = new System.Drawing.Size(43, 17);
            this.radioButtonBuy.TabIndex = 1;
            this.radioButtonBuy.TabStop = true;
            this.radioButtonBuy.Text = "Buy";
            this.radioButtonBuy.UseVisualStyleBackColor = true;
            this.radioButtonBuy.CheckedChanged += new System.EventHandler(this.radioButtonBuy_CheckedChanged);
            // 
            // groupBoxLastTrade
            // 
            this.groupBoxLastTrade.Controls.Add(this.labelLastTradeResult);
            this.groupBoxLastTrade.Controls.Add(this.labelSellerValue);
            this.groupBoxLastTrade.Controls.Add(this.labelSeller);
            this.groupBoxLastTrade.Controls.Add(this.labelBuyerValue);
            this.groupBoxLastTrade.Controls.Add(this.labelBuyer);
            this.groupBoxLastTrade.Location = new System.Drawing.Point(12, 190);
            this.groupBoxLastTrade.Name = "groupBoxLastTrade";
            this.groupBoxLastTrade.Size = new System.Drawing.Size(200, 144);
            this.groupBoxLastTrade.TabIndex = 2;
            this.groupBoxLastTrade.TabStop = false;
            this.groupBoxLastTrade.Text = "Last Trade";
            // 
            // labelLastTradeResult
            // 
            this.labelLastTradeResult.AutoSize = true;
            this.labelLastTradeResult.Location = new System.Drawing.Point(12, 97);
            this.labelLastTradeResult.Name = "labelLastTradeResult";
            this.labelLastTradeResult.Size = new System.Drawing.Size(107, 13);
            this.labelLastTradeResult.TabIndex = 4;
            this.labelLastTradeResult.Text = "labelLastTradeResult";
            // 
            // labelSellerValue
            // 
            this.labelSellerValue.AutoSize = true;
            this.labelSellerValue.Location = new System.Drawing.Point(55, 59);
            this.labelSellerValue.Name = "labelSellerValue";
            this.labelSellerValue.Size = new System.Drawing.Size(82, 13);
            this.labelSellerValue.TabIndex = 3;
            this.labelSellerValue.Text = "labelSellerValue";
            // 
            // labelSeller
            // 
            this.labelSeller.AutoSize = true;
            this.labelSeller.Location = new System.Drawing.Point(12, 59);
            this.labelSeller.Name = "labelSeller";
            this.labelSeller.Size = new System.Drawing.Size(36, 13);
            this.labelSeller.TabIndex = 2;
            this.labelSeller.Text = "Seller:";
            // 
            // labelBuyerValue
            // 
            this.labelBuyerValue.AutoSize = true;
            this.labelBuyerValue.Location = new System.Drawing.Point(55, 28);
            this.labelBuyerValue.Name = "labelBuyerValue";
            this.labelBuyerValue.Size = new System.Drawing.Size(83, 13);
            this.labelBuyerValue.TabIndex = 1;
            this.labelBuyerValue.Text = "labelBuyerValue";
            // 
            // labelBuyer
            // 
            this.labelBuyer.AutoSize = true;
            this.labelBuyer.Location = new System.Drawing.Point(12, 28);
            this.labelBuyer.Name = "labelBuyer";
            this.labelBuyer.Size = new System.Drawing.Size(37, 13);
            this.labelBuyer.TabIndex = 0;
            this.labelBuyer.Text = "Buyer:";
            // 
            // textBoxOrderHistory
            // 
            this.textBoxOrderHistory.Location = new System.Drawing.Point(218, 30);
            this.textBoxOrderHistory.Multiline = true;
            this.textBoxOrderHistory.Name = "textBoxOrderHistory";
            this.textBoxOrderHistory.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxOrderHistory.Size = new System.Drawing.Size(284, 304);
            this.textBoxOrderHistory.TabIndex = 3;
            // 
            // textBoxMarketOrders
            // 
            this.textBoxMarketOrders.Location = new System.Drawing.Point(508, 30);
            this.textBoxMarketOrders.Multiline = true;
            this.textBoxMarketOrders.Name = "textBoxMarketOrders";
            this.textBoxMarketOrders.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxMarketOrders.Size = new System.Drawing.Size(284, 304);
            this.textBoxMarketOrders.TabIndex = 4;
            // 
            // labelOrderHistory
            // 
            this.labelOrderHistory.AutoSize = true;
            this.labelOrderHistory.Location = new System.Drawing.Point(218, 14);
            this.labelOrderHistory.Name = "labelOrderHistory";
            this.labelOrderHistory.Size = new System.Drawing.Size(68, 13);
            this.labelOrderHistory.TabIndex = 5;
            this.labelOrderHistory.Text = "Order History";
            // 
            // labelMarket
            // 
            this.labelMarket.AutoSize = true;
            this.labelMarket.Location = new System.Drawing.Point(508, 14);
            this.labelMarket.Name = "labelMarket";
            this.labelMarket.Size = new System.Drawing.Size(74, 13);
            this.labelMarket.TabIndex = 6;
            this.labelMarket.Text = "Market Orders";
            // 
            // textBoxTrades
            // 
            this.textBoxTrades.Location = new System.Drawing.Point(798, 29);
            this.textBoxTrades.Multiline = true;
            this.textBoxTrades.Name = "textBoxTrades";
            this.textBoxTrades.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxTrades.Size = new System.Drawing.Size(284, 304);
            this.textBoxTrades.TabIndex = 7;
            // 
            // labelTrades
            // 
            this.labelTrades.AutoSize = true;
            this.labelTrades.Location = new System.Drawing.Point(795, 12);
            this.labelTrades.Name = "labelTrades";
            this.labelTrades.Size = new System.Drawing.Size(40, 13);
            this.labelTrades.TabIndex = 8;
            this.labelTrades.Text = "Trades";
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(12, 341);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(75, 23);
            this.buttonClear.TabIndex = 9;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // textBoxAccountNumber
            // 
            this.textBoxAccountNumber.Location = new System.Drawing.Point(56, 39);
            this.textBoxAccountNumber.Name = "textBoxAccountNumber";
            this.textBoxAccountNumber.Size = new System.Drawing.Size(133, 20);
            this.textBoxAccountNumber.TabIndex = 7;
            // 
            // labelAccount
            // 
            this.labelAccount.AutoSize = true;
            this.labelAccount.Location = new System.Drawing.Point(6, 46);
            this.labelAccount.Name = "labelAccount";
            this.labelAccount.Size = new System.Drawing.Size(47, 13);
            this.labelAccount.TabIndex = 8;
            this.labelAccount.Text = "Account";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1091, 376);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.labelTrades);
            this.Controls.Add(this.textBoxTrades);
            this.Controls.Add(this.labelMarket);
            this.Controls.Add(this.labelOrderHistory);
            this.Controls.Add(this.textBoxMarketOrders);
            this.Controls.Add(this.textBoxOrderHistory);
            this.Controls.Add(this.groupBoxLastTrade);
            this.Controls.Add(this.groupBoxOrderForm);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBoxOrderForm.ResumeLayout(false);
            this.groupBoxOrderForm.PerformLayout();
            this.groupBoxLastTrade.ResumeLayout(false);
            this.groupBoxLastTrade.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonPlaceOrder;
        private System.Windows.Forms.GroupBox groupBoxOrderForm;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.Label labelAmount;
        private System.Windows.Forms.TextBox textBoxPrice;
        private System.Windows.Forms.TextBox textBoxAmount;
        private System.Windows.Forms.RadioButton radioButtonSell;
        private System.Windows.Forms.RadioButton radioButtonBuy;
        private System.Windows.Forms.GroupBox groupBoxLastTrade;
        private System.Windows.Forms.Label labelBuyerValue;
        private System.Windows.Forms.Label labelBuyer;
        private System.Windows.Forms.Label labelLastTradeResult;
        private System.Windows.Forms.Label labelSellerValue;
        private System.Windows.Forms.Label labelSeller;
        private System.Windows.Forms.TextBox textBoxOrderHistory;
        private System.Windows.Forms.TextBox textBoxMarketOrders;
        private System.Windows.Forms.Label labelOrderHistory;
        private System.Windows.Forms.Label labelMarket;
        private System.Windows.Forms.TextBox textBoxTrades;
        private System.Windows.Forms.Label labelTrades;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Label labelAccount;
        private System.Windows.Forms.TextBox textBoxAccountNumber;
    }
}

