using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CurrencyConverter.View
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CashierDialog cashierDialog = new CashierDialog();
            cashierDialog.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Model.ApplicationContext.dateTime = Model.ApplicationContext.dateTime.AddDays(1);
            for (int i = 0; i < Model.ApplicationContext.Clients.Count; i++) 
            {
                Model.ApplicationContext.Clients[i].CurrencyLimit = 1000;
            }
        }
    }
}
