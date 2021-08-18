using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Currency_Converter
{
    public class ConverterPresenter
    {
        private ConverterModel model;
        private IConverter screen;

        public ConverterPresenter(IConverter screen)
        {
            this.screen = screen;
            screen.Register(this);
            model = new ConverterModel();
            setComboBoxes();
        }

        public void setComboBoxes()
        {
            screen.setFirstComboBox(model.getCurrencyList());
            screen.setSecondComboBox(model.getCurrencyList());
        }

        public void convert()
        {
            double convertedToAmount = model.getConvertedAmount(screen.getConvertedFromCurrency(), screen.getConvertedToCurrency(), screen.getConvertedFromAmount());
            screen.setConvertedToAmount(convertedToAmount);
            model.saveConversion(screen.getConvertedFromCurrency(), screen.getConvertedToCurrency(), screen.getConvertedFromAmount(), convertedToAmount);
        }
    }
}
