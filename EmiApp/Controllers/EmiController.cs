

using Microsoft.AspNetCore.Mvc;
using EmiCalc.Models;




namespace EmiCalc.Controllers

{
    public class EmiController: Controller
    {
        public IActionResult Index()
        {

            return View();
        
        
        
        }

       

        public IActionResult Display(double principal, double rate, double duration)
        {

            Request request = new Request();
            request.Principal = principal;
            
            request.InterestRateInPercentage = rate;
            request.LoanDurationInYearCount = duration;

            //Calculations
            double MonthlyEmi = (double)request.Principal * System.Math.Pow(1 + (request.InterestRateInPercentage / 100) / 12, request.LoanDurationInYearCount * 12);
            
            double ContinousEmi = (double)request.Principal * System.Math.Pow(2.7183, (request.InterestRateInPercentage / 100 * request.LoanDurationInYearCount));
            double DailyEmi = ((double)request.Principal * System.Math.Pow(1 + ((request.InterestRateInPercentage / 100) / 365), 365 * request.LoanDurationInYearCount)) - (double)request.Principal;
           
            //Rounding the double
            MonthlyEmi=Math.Round(MonthlyEmi, 2);
            
            DailyEmi = Math.Round(DailyEmi, 2);
            ContinousEmi = Math.Round(ContinousEmi, 2);

            request.DailyEmi = DailyEmi;
            request.MonthlyEmi = MonthlyEmi;
            request.ContinousEmi = ContinousEmi;

            return View(request);


        }


    }
}
