using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using View;

namespace Presenter
{
    public class SetTimePresenter
    {
        private ISetTime _view;
        public SetTimePresenter(ISetTime view)
        {
            _view = view;
        }
        public void Submit()
        {
            Model.ApplicationContext.dateTime = _view.SetNewTime();
            MessageBox.Show("Date change");
        }
    }
}
