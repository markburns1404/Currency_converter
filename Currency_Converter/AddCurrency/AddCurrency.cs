using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Currency_Converter
{
    public partial class AddCurrency : Form, IAddCurrency
    {
        private AddCurrencyPresenter presenter;
        public AddCurrency()
        {
            InitializeComponent();
        }

        public void currencyAdded()
        {
            MessageBox.Show("Currency Added");
            this.Close();
        }

        public string getCurrencyAmount()
        {
            return txt_currency_value.Text;
        }

        public string getCurrencyName()
        {
            return txt_currency_name.Text;
        }

        public void Register(AddCurrencyPresenter presenter)
        {
            this.presenter = presenter;
        }

        public void showMessage()
        {
            MessageBox.Show("Currency amount must be numerical value");
        }

        private void btn_add_currency_Click(object sender, EventArgs e)
        {
            if (txt_currency_name.Text.Length > 0 && txt_currency_value.Text.Length > 0)
            {
                presenter.AddCurrency();
            }
            else
            {
                MessageBox.Show("Please fill all text boxes");
            }
        }
    }
}
