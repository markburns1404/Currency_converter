using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Currency_Converter
{
    public class AuditModel
    {
        public DataTable getData(DateTime startDate, DateTime endDate)
        {
            DataTable dt = new DataTable();
            try
            {
                using (var context = new DBEntities())
                {
                    var conversionHistories = context.ConversionHistories.ToList();



                    dt.Columns.Add("ConvertedFrom", typeof(string));
                    dt.Columns.Add("ConvertedTo", typeof(string));
                    dt.Columns.Add("AmountFrom", typeof(double));
                    dt.Columns.Add("AmountTo", typeof(double));
                    dt.Columns.Add("ConversionRate", typeof(double));
                    dt.Columns.Add("DateConverted", typeof(DateTime));

                    var appointmentQuery = from c in conversionHistories.AsEnumerable()
                                           where c.DateConverted >= startDate && c.DateConverted <= endDate
                                           select dt.LoadDataRow(new object[]
                                           {
                                       c.ConvertedFrom,
                                        c.ConvertedTo,
                                        c.AmountFrom,
                                        c.AmountTo,
                                        c.ConversionRate,
                                        c.DateConverted
                                           }, false);

                    appointmentQuery.CopyToDataTable();



                }
            }
            catch (Exception f)
            {
                Console.WriteLine("No Conversions between this period " + f.Message);
            }
            return dt;
        }
    }
}
