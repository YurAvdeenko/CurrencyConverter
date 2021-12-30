using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using View;

namespace CurrencyConverter.View
{
    public partial class CashierDialog : Form
    {
        public CashierDialog()
        {
            InitializeComponent();
            buyDollarLabel.Text = Model.ApplicationContext.Currencies.Where(x => x.CurrencyName == "Dollar").FirstOrDefault().BuyRate.ToString();
            buyEuroLabel.Text = Model.ApplicationContext.Currencies.Where(x => x.CurrencyName == "Euro").FirstOrDefault().BuyRate.ToString();
            buyRublsLabel.Text = Model.ApplicationContext.Currencies.Where(x => x.CurrencyName == "Rubls").FirstOrDefault().BuyRate.ToString();
            sellDollarLabel.Text = Model.ApplicationContext.Currencies.Where(x => x.CurrencyName == "Dollar").FirstOrDefault().SellRate.ToString();
            sellEuroLabel.Text = Model.ApplicationContext.Currencies.Where(x => x.CurrencyName == "Euro").FirstOrDefault().SellRate.ToString();
            sellRublsLabel.Text = Model.ApplicationContext.Currencies.Where(x => x.CurrencyName == "Rubls").FirstOrDefault().SellRate.ToString();
        }

        private void setLimitButton_Click(object sender, EventArgs e)
        {
            NewLimit newLimit = new NewLimit();
            newLimit.ShowDialog();
        }

        private void setTimeButton_Click(object sender, EventArgs e)
        {
            SetTime setTime = new SetTime();
            setTime.ShowDialog();
        }

        private void changeDollarRateButton_Click(object sender, EventArgs e)
        {
            ChangeRate changeRate = new ChangeRate(Model.ApplicationContext.Currencies.Where(x=>x.CurrencyName =="Dollar").FirstOrDefault().CurrencyId);
            changeRate.ShowDialog();
        }

        private void changeEuroRateButton_Click(object sender, EventArgs e)
        {
            ChangeRate changeRate = new ChangeRate(Model.ApplicationContext.Currencies.Where(x => x.CurrencyName == "Euro").FirstOrDefault().CurrencyId);
            changeRate.ShowDialog();
        }

        private void changeRublsRateButton_Click(object sender, EventArgs e)
        {
            ChangeRate changeRate = new ChangeRate(Model.ApplicationContext.Currencies.Where(x => x.CurrencyName == "Rubls").FirstOrDefault().CurrencyId);
            changeRate.ShowDialog();
        }
    }
}
