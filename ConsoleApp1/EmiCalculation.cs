using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class EmiCalculation
    {

        internal int p { private get; set; }
        internal double i { private get; set; }

        internal int t { private get; set; }

        internal int n{ private get; set; }

        internal EmiResult GetEmiResult()
        {
            var emi=new EmiResult();
            emi.calculate = CalculateEmi();
            return emi;
        }

        private double CalculateEmi()
        {
            double result = 0;

            result =  (1 + (i / n));

            result = p*Math.Pow(result,(t*n));

            result = result / (t * n);

            result = Math.Round(result, 2);

            

            return result;

        }


    }
}
