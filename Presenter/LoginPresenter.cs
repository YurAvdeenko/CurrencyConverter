using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using View;
using Model;

namespace Presenter
{
    public class LoginPresenter
    {
        private ILoginView _view;

        public LoginPresenter(ILoginView view)
        {
            _view = view;
        }

        public Client Submit()
        {
            Client newClient = new Client(_view.GetName());
            var client = Model.ApplicationContext.Clients.Where(x => x.Name == newClient.Name).FirstOrDefault();
            if(client != null)
            {
                MessageBox.Show("You are in");
                _view.Close();
                return Model.ApplicationContext.Clients.Where(x => x.Name == newClient.Name).FirstOrDefault();
            }
            else
            {
                Model.ApplicationContext.Clients.Add(newClient);
                MessageBox.Show("You are in base");
                _view.Close();
                return newClient;
            }            
        }
    }
}
