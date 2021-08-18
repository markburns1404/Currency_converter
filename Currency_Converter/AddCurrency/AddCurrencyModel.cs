using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Currency_Converter
{
    public class AddCurrencyModel
    {
        public void addCurrency(string currency, double amount)
        {
            using (var context = new DBEntities())
            {
                Currency c = new Currency();

                c.currencyID = currency;
                c.multipliedFromGBP = amount;
                

                context.Currencies.Add(c);
                context.SaveChanges();
            }
        }
    }
}
