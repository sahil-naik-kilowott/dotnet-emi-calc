using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class EmiCalculation
    {

        internal int P { private get; set; }
        internal double I { private get; set; }

        internal int T { private get; set; }

        internal int N{ private get; set; }

        internal EmiResult GetEmiResult()
        {
            var emi=new EmiResult();
            emi.calculate = CalculateEmi();
            return emi;
        }

        private double CalculateEmi()
        {
            double result = 0;

            result =  (1 + (I / N));

            result = P*Math.Pow(result,(T*N));

            result = result / (T * N);

            result = Math.Round(result, 2);

            

            return result;

        }


    }
}
