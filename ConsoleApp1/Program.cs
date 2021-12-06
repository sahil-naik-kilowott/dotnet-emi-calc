// See https://aka.ms/new-console-template for more information


using System;

namespace ConsoleApp1
{
    internal class Program
    {

        public static void Main(string[] args)
        {


            Console.Write("Enter the Price of the Vehicle: ");
            int Price= Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Rate of interest: ");
            double rate= Convert.ToInt32(Console.ReadLine());
            double ROI =rate / 100;
            Console.Write("Enter Loan Duration: ");
            int Term= Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Monthly Compounding: ");
            int Months = Convert.ToInt32(Console.ReadLine());

            

            var spObj = new EmiCalculation();

            spObj.P = Price;
            spObj.I = ROI;
            spObj.T = Term;
            spObj.N = Months;

            var res=spObj.GetEmiResult();

            Console.WriteLine($"Monthly Emi: {res.calculate} INR");




        }

    }
}
