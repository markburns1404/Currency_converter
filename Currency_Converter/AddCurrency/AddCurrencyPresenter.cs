using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Currency_Converter
{
    public class AddCurrencyPresenter
    {
        private AddCurrencyModel model;
        private IAddCurrency screen;

        public AddCurrencyPresenter(IAddCurrency screen)
        {
            this.screen = screen;
            screen.Register(this);
            model = new AddCurrencyModel();
        }

        public void AddCurrency()
        {
            try
            {
                double currencyValue = Convert.ToDouble(screen.getCurrencyAmount());
                model.addCurrency(screen.getCurrencyName(), currencyValue);
                screen.currencyAdded();
            }
            catch (Exception f)
            {
                Console.WriteLine("Cannot convert string to double " + f.Message);
                screen.showMessage();
            }
        }
    }
}
