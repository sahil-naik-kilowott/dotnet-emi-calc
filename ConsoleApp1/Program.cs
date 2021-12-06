// See https://aka.ms/new-console-template for more information


using System;

namespace ConsoleApp1
{
    internal class Program
    {

        public static void Main(string[] args)
        {
            int Price,Term,Months;
            double Rate, ROI;
            


            try
            {

                Console.Write("Enter the Price of the Vehicle: ");
                Price = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter Rate of interest: ");
                Rate = Convert.ToInt32(Console.ReadLine());
                ROI = Rate / 100;
                Console.Write("Enter Loan Duration: ");
                Term = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter Monthly Compounding: ");
                Months = Convert.ToInt32(Console.ReadLine());



                var spObj = new EmiCalculation();

                spObj.P = Price;
                spObj.I = ROI;
                spObj.T = Term;
                spObj.N = Months;

                var res = spObj.GetEmiResult();

                Console.WriteLine($"Monthly Emi: {res.calculate} INR");

            }

            catch(Exception ex)
            {
                Console.Write("Error info:" + ex.Message);

            }

            finally
            {
                Console.WriteLine("Now Retry the program with different parameters.");
            }



        }

    }
}
