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
using Presenter;

namespace CurrencyConverter.View
{
    public partial class ChangeRate : Form, IChangeRateView
    {
        private ChangeRatePresenter _presenter;
        private int IdCurrency { get; set; }
        public ChangeRate(int idCurrency)
        {
            InitializeComponent();
            IdCurrency = idCurrency;
            _presenter = new ChangeRatePresenter(this);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _presenter.Submit(IdCurrency);
            this.Close();
        }

        public double ChangeSellRate()
        {
            return Convert.ToDouble(sellTextBox.Text);
        }
        public double ChangeBuyRate()
        {
            return Convert.ToDouble(buyTextBox.Text);
        }
    }
}
