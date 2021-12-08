using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmiApp
{
    public class Request
    {
        public decimal Principal { internal get; set; }
        public double InterestRateInPercentage { internal get; set; }
        public int LoanDurationInYearCount { internal get; set; }
    }
}
