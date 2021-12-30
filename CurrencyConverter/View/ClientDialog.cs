using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Model;
using View;
using Presenter;

namespace CurrencyConverter.View
{
    public partial class ClientDialog : Form, IClientView
    {
        private ClientPresenter _presenter;
        private Client newClient;
        private List<RadioButton> radioButtons;
        public ClientDialog(Client client)
        {
            InitializeComponent();
            radioButtons = new List<RadioButton>();
            radioButtons.Add(radioButton1);
            radioButtons.Add(radioButton2);
            radioButtons.Add(radioButton3);
            radioButtons.Add(radioButton4);
            radioButtons.Add(radioButton5);
            radioButtons.Add(radioButton6);

            buyDollarLabel.Text = Model.ApplicationContext.Currencies.Where(x => x.CurrencyName == "Dollar").FirstOrDefault().BuyRate.ToString();
            buyEuroLabel.Text = Model.ApplicationContext.Currencies.Where(x => x.CurrencyName == "Euro").FirstOrDefault().BuyRate.ToString();
            buyRublsLabel.Text = Model.ApplicationContext.Currencies.Where(x => x.CurrencyName == "Rubls").FirstOrDefault().BuyRate.ToString();
            sellDollarLabel.Text = Model.ApplicationContext.Currencies.Where(x => x.CurrencyName == "Dollar").FirstOrDefault().SellRate.ToString();
            sellEuroLabel.Text = Model.ApplicationContext.Currencies.Where(x => x.CurrencyName == "Euro").FirstOrDefault().SellRate.ToString();
            sellRublsLabel.Text = Model.ApplicationContext.Currencies.Where(x => x.CurrencyName == "Rubls").FirstOrDefault().SellRate.ToString();

            dateLabel.Text = Model.ApplicationContext.dateTime.Date.ToString();
            limitLabel.Text = client.CurrencyLimit.ToString();
            _presenter = new ClientPresenter(this);
            newClient = client;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (newClient.CurrencyLimit < 0)
            {
                MessageBox.Show("Your today limit is 0");
            }
            if(GetSumOfOperation() > newClient.CurrencyLimit)
            {
                MessageBox.Show($"Your today limit is {newClient.CurrencyLimit}");
            }
            else
            {
                _presenter.Submit(newClient.Id);
            }
        }

        public void SetLimit(int id)
        {
            limitLabel.Text = Model.ApplicationContext.Clients.Where(x => x.Id == id).FirstOrDefault().CurrencyLimit.ToString();
        }
        public int GetIndexOfOperation()
        {
            for (int i = 0; i < radioButtons.Count; i++)
            {
                if (radioButtons[i].Checked == true)
                    return i;
            }
            return -1;
        }

        public double GetSumOfOperation()
        {
            return Convert.ToDouble(exchangeTextBox.Text);
        }

        public double GetSellCurrencyRate(int index)
        { 
            return Model.ApplicationContext.Currencies.Where(x => x.CurrencyName == radioButtons[index].Text).FirstOrDefault().SellRate;
        }

        public double GetBuyCurrencyRate(int index)
        {
            return Model.ApplicationContext.Currencies.Where(x => x.CurrencyName == radioButtons[index].Text).FirstOrDefault().BuyRate;
        }

        public string GetCurrencyName(int index)
        {
            return Model.ApplicationContext.Currencies.Where(x => x.CurrencyName == radioButtons[index].Text).FirstOrDefault().CurrencyName;
        }
    }
}
