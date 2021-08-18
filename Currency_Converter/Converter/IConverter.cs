using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Currency_Converter
{
    public interface IConverter
    {
        void Register(ConverterPresenter converterPresenter);
        void setFirstComboBox(List<String> currencies);
        void setSecondComboBox(List<String> currencies);
        string getConvertedFromCurrency();
        string getConvertedToCurrency();
        double getConvertedFromAmount();
        void setConvertedToAmount(double convertedToAmount);
    }
}
