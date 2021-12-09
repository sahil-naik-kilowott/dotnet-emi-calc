namespace EmiCalc.Models
{
    public class Request
    {

        public double Principal { internal get; set; }
        public double InterestRateInPercentage { internal get; set; }
        public double LoanDurationInYearCount { internal get; set; }
        public double MonthlyEmi { internal get; set; }
        public double DailyEmi { internal get; set; }
        public double ContinousEmi { internal get; set; }
    }
}
