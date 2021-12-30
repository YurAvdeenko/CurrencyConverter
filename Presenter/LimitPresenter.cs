using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using View;

namespace Presenter
{
    public class LimitPresenter
    {
        private INewLimit _view;
        public LimitPresenter(INewLimit view)
        {
            _view = view;
        }
        public void Submit()
        {
            int newLimit = _view.SetNewLimit();
            for (int i = 0; i < Model.ApplicationContext.Clients.Count; i++)
            {
                Model.ApplicationContext.Clients[i].CurrencyLimit = newLimit;
            }
            MessageBox.Show($"Limit is changed to {newLimit}");
        }
        
    }
}
