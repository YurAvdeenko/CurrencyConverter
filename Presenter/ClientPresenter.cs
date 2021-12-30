using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using View;

namespace Presenter
{
    public class ClientPresenter
    {
        private IClientView _view;
        public ClientPresenter(IClientView view)
        {
            _view = view;
        }

        public void Submit(int id)
        {
            double outSum = 0;
            double sellRate = 0;
            double buyRate = 0;
            var index = _view.GetIndexOfOperation();
            double sum = _view.GetSumOfOperation();
            string nameOfCurrency = _view.GetCurrencyName(index);
            if (index == -1)
            {
                return;
            }

            if(index >= 0 && index <= 2)
            {
                sellRate = _view.GetSellCurrencyRate(index);
                outSum = Model.ApplicationContext.Clients.Where(x => x.Id == id).FirstOrDefault().ExchangeMoney(sum, sellRate, id);
                MessageBox.Show($"You sold {sum} {nameOfCurrency} for {outSum} BYN");
                _view.SetLimit(id);
            }
            else if(index >= 3 && index <= 5)
            {
                buyRate = _view.GetBuyCurrencyRate(index);
                outSum = Model.ApplicationContext.Clients.Where(x => x.Id == id).FirstOrDefault().ExchangeMoney(sum, buyRate, id);
                MessageBox.Show($"You bought {sum} {nameOfCurrency} for {outSum} BYN");
                _view.SetLimit(id);
            }
        }
    }
}
