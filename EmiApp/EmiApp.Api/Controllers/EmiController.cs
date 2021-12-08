
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
namespace EmiApp.Api.Controllers
{


  
    [ApiController]

    public class EmiController: ControllerBase
    {


        [HttpPost]
        [Route("api/[controller]CalculateMonthlyEmi")]

        public Response CalculateMonthlyEmi(Request request)
        {
            ICalculator emiCalculator = new Calculator(); 
            var response = new Response(); 
            var emiMonthly = emiCalculator.CalculateMonthlyEmi(request);
            return emiMonthly;
        }



        [HttpPost]
        [Route("api/[controller]CalculateDaillyEmi")]

        public Response CalculateDailyEmi(Request request)
        {
            ICalculator emiCalculator = new Calculator();
            var response = new Response();
            var emiDaily = emiCalculator.CalculateDailyEmi(request);
            return emiDaily;
        }


        [HttpPost]
        [Route("api/[controller]CalculateContinousEmi")]

        public Response CalculateContinousEmi(Request request)
        {
            ICalculator emiCalculator = new Calculator();
            var response = new Response();
            var emiContinous = emiCalculator.CalculateContinousEmi(request);
            return emiContinous;
        }


    }
}
