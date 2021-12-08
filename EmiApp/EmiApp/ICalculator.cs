namespace EmiApp
{
    public interface ICalculator
    {
        public Response CalculateMonthlyEmi(Request request);
        public Response CalculateDailyEmi(Request request);
        public Response CalculateContinousEmi(Request request);
    }
}
