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
    public partial class NewLimit : Form, INewLimit
    {
        private LimitPresenter _presenter;
        public NewLimit()
        {
            InitializeComponent();
            _presenter = new LimitPresenter(this);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _presenter.Submit();
            this.Close();
        }
        public int SetNewLimit()
        {
            return Convert.ToInt32(textBox1.Text);
        }
    }
}
