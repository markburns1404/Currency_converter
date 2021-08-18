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
    public partial class Converter : Form, IConverter
    {
        private ConverterPresenter presenter;
        public Converter()
        {
            InitializeComponent();
        }

        public double getConvertedFromAmount()
        {
            try
            {
                return Convert.ToDouble(txt_convert_from.Text);
            }
            catch (Exception f)
            {
                Console.WriteLine("Incorrect Input " + f.Message);
                txt_convert_from.Text = "1";
                MessageBox.Show("Convert numbers only please");
                return Convert.ToDouble(txt_convert_from.Text);
            }
        }

        public string getConvertedFromCurrency()
        {
            return cmb_converted_from.SelectedItem.ToString();
        }

        public string getConvertedToCurrency()
        {
            return cmb_converted_to.SelectedItem.ToString();
        }

        public void Register(ConverterPresenter converterPresenter)
        {
            this.presenter = converterPresenter;
        }

        public void setConvertedToAmount(double convertedToAmount)
        {
            txt_convert_to.Text = convertedToAmount.ToString();
        }

        public void setFirstComboBox(List<string> currencies)
        {
            cmb_converted_from.DataSource = currencies;
        }

        public void setSecondComboBox(List<string> currencies)
        {
            cmb_converted_to.DataSource = currencies;
        }

        private void btn_convert_Click(object sender, EventArgs e)
        {
            if (txt_convert_from.Text.Length > 0)
            {
                presenter.convert();
            }
            else
            {
                MessageBox.Show("There must be a value in the conversion box");
            }
        }
    }
}
