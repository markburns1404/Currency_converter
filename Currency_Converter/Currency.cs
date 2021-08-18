using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;

namespace Currency_Converter
{
    public class Currency
    {
        [Key]
        public string currencyID { get; set; }
        public double multipliedFromGBP { get; set; }
    }
}
