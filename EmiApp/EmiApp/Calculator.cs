namespace EmiApp
{
    public class Calculator: ICalculator
    {
        public Response CalculateContinousEmi(Request request)
        {
            //throw new NotImplementedException();
            /** 
                 A = P × e^(rt)
                
                A = Amount of money after a certain amount of time
                P = Principle or the amount of money you start with
                e = Napier’s number, which is approximately 2.7183
                r = Interest rate and is always represented as a decimal
                t = Amount of time in years

             **/
            var response = new Response();
            try
            {

                var rate = request.InterestRateInPercentage / 100;
                var power = request.LoanDurationInYearCount * rate;
                var accumulated = (double)request.Principal * System.Math.Pow(2.7183, power);
                accumulated = System.Math.Round(accumulated, 3);
                // convert to response object
                response.EmiPayment = (decimal)accumulated;
                return response;
            }
            catch (Exception ex)
            {
                response = new Response() { ErrorMessage = ex.Message.ToString() };
            }
            finally { }
            return response;
        }



        public Response CalculateDailyEmi(Request request)
        {
            //throw new NotImplementedException();
            var response = new Response();
            try
            {
                var power = request.LoanDurationInYearCount * 365;
                var rate = request.InterestRateInPercentage / 100;
                var accumulated = ((double)request.Principal * System.Math.Pow(1 + rate / 365, power)) - (double)request.Principal;
                
                accumulated = System.Math.Round(accumulated, 3);
                response.EmiPayment = (decimal)accumulated;
                // convert to response object
                return response;
            }
            catch (Exception ex)
            {
                response = new Response() { ErrorMessage = ex.Message.ToString() };
            }
            finally { }
            return response;

        }

        public Response CalculateMonthlyEmi(Request request)
        {
            var response = new Response();
            try
            {
                var power = request.LoanDurationInYearCount * 12;
                var rate = request.InterestRateInPercentage / 100;
                var accumulated = (double)request.Principal * System.Math.Pow(1 + rate / 12, power);
                accumulated= System.Math.Round(accumulated, 3);
                response.EmiPayment = (decimal)accumulated;
                
                // convert to response object
                return response;
            }
            catch (Exception ex)
            {
                response = new Response() { ErrorMessage = ex.Message.ToString() };
            }
            finally { }
            return response;
        }
    }
}