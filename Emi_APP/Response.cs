namespace EmiApp
{
    public class Response
    {
        public decimal EmiPayment { get; set; }
        public string EmiPaymentType { get; set; } = string.Empty; // for example "monthly", "daily", "continuous"
        public string ErrorMessage { get; set; } = string.Empty;
    }
}