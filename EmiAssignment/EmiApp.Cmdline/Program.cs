using System;

namespace EmiApp.Cmdline
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var emiRequest = new Request() { Principal = 100000, InterestRateInPercentage = 12, LoanDurationInYearCount = 2 };
            ICalculator emiCalculator = new Calculator();



            #region monthly compounding
            var emiMonthly = emiCalculator.CalculateMonthlyEmi(emiRequest);
            if (string.IsNullOrEmpty(emiMonthly.ErrorMessage))
                Console.WriteLine($"Monthly EMI: {emiMonthly.EmiPayment} INR");
            else 
                Console.WriteLine(emiMonthly.ErrorMessage);
            #endregion 

            // fill other regions below...
            #region daily compounding
            var emiDaily = emiCalculator.CalculateDailyEmi(emiRequest);

            if (string.IsNullOrEmpty(emiMonthly.ErrorMessage))
                Console.WriteLine($"Daily EMI: {emiDaily.EmiPayment} INR");
            else
                Console.WriteLine(emiMonthly.ErrorMessage);
            #endregion


            #region continuous emi
            var emiContinous = emiCalculator.CalculateContinousEmi(emiRequest);

            if (string.IsNullOrEmpty(emiMonthly.ErrorMessage))
                Console.WriteLine($"Continous EMI: {emiContinous.EmiPayment} INR");
            else
                Console.WriteLine(emiMonthly.ErrorMessage);
            #endregion


        }
    }
}

