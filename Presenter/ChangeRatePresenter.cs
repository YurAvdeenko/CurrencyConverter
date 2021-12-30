using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using View;

namespace Presenter
{
    public class ChangeRatePresenter
    {
        IChangeRateView _view;
        public ChangeRatePresenter(IChangeRateView view)
        {
            _view = view;
        }
        public void Submit(int idCurrency)
        {
            double newBuyRate = _view.ChangeBuyRate();
            double newSellRate = _view.ChangeSellRate();
            Model.ApplicationContext.Currencies.Where(x => x.CurrencyId == idCurrency).FirstOrDefault().BuyRate = newBuyRate;
            Model.ApplicationContext.Currencies.Where(x => x.CurrencyId == idCurrency).FirstOrDefault().SellRate = newSellRate;
        }
    }
}
