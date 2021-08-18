using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Currency_Converter
{
    public class ConverterModel
    {
        public List<string> getCurrencyList()
        {
            using (var context = new DBEntities())
            {
                var currency = context.Currencies.ToList();

                var currencyListQuery = from c in currency.AsEnumerable()
                                        select c.currencyID;

                var currencyList = currencyListQuery.ToList();
                return currencyList;
            }
        }

        public double getConvertedAmount(string convertedFromCurrency, string convertedToCurrency, double convertedFromAmount)
        {
            double fromConversion = getMultipliedFromGBP(convertedFromCurrency);
            double toConversion = getMultipliedFromGBP(convertedToCurrency);

            double convertedToAmount = ((convertedFromAmount / fromConversion) * toConversion);

            convertedToAmount = Math.Round((Double)convertedToAmount, 2);

            return convertedToAmount;
        }

        public double getMultipliedFromGBP(string selectedCurrency)
        {
            using (var context = new DBEntities())
            {
                var currency = context.Currencies.ToList();

                var currencyQuery = from c in currency.AsEnumerable()
                                   where c.currencyID == selectedCurrency
                                   select c.multipliedFromGBP;

                var multipliedFromGBP = currencyQuery.ToList();
                double multipliedFromGBPAmount = Convert.ToDouble(multipliedFromGBP[0].ToString());

                return multipliedFromGBPAmount;

            }

        }
        public void saveConversion(string convertedFromCurrency, string convertedToCurrency, double convertedFromAmount, double convertedToAmount)
        {
            using (var context = new DBEntities())
            {
                ConversionHistory conversionHistory = new ConversionHistory();

                conversionHistory.ConvertedFrom = convertedFromCurrency;
                conversionHistory.ConvertedTo = convertedToCurrency;
                conversionHistory.AmountFrom = convertedFromAmount;
                conversionHistory.AmountTo = convertedToAmount;
                conversionHistory.ConversionRate = convertedToAmount / convertedFromAmount;
                conversionHistory.DateConverted = DateTime.Today.Date;

                context.ConversionHistories.Add(conversionHistory);
                context.SaveChanges();
            }
        }
    }
}
