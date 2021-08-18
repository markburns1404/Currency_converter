using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Currency_Converter
{
    public interface IAddCurrency
    {
        string getCurrencyName();
        string getCurrencyAmount();
        void Register(AddCurrencyPresenter presenter);
        void showMessage();
        void currencyAdded();
    }
}
