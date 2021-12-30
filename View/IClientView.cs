using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace View
{
    public interface IClientView : IView
    {
        int GetIndexOfOperation();
        double GetSumOfOperation();
        double GetSellCurrencyRate(int index);
        double GetBuyCurrencyRate(int index);
        string GetCurrencyName(int index);
        void SetLimit(int id);
    }
}
