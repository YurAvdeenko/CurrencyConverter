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
    public partial class SetTime : Form, ISetTime
    {
        SetTimePresenter _presenter;
        public SetTime()
        {
            InitializeComponent();
            _presenter = new SetTimePresenter(this);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            _presenter.Submit();
            this.Close();
        }

        public DateTime SetNewTime()
        {
            return DateTime.Parse(textBox1.Text);
        }
    }
}
