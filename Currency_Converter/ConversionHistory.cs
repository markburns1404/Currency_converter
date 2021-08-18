using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.Text;
using System.Threading.Tasks;

namespace Currency_Converter
{
    public class ConversionHistory
    {
        [Key]
        public int historyID { get; set; }
        public string ConvertedFrom { get; set; }
        public string ConvertedTo { get; set; }
        public double AmountFrom { get; set; }
        public double AmountTo { get; set; }
        public double ConversionRate { get; set; }
        public DateTime DateConverted { get; set; }
    }
}
