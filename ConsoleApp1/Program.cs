// See https://aka.ms/new-console-template for more information


using System;

namespace ConsoleApp1
{
    internal class Program
    {

        public static void Main(string[] args)
        {


            Console.Write("Enter the Price of the Vehicle: ");
            int p= Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Rate of interest: ");
            double rate= Convert.ToInt32(Console.ReadLine());
            double i =rate / 100;
            Console.Write("Enter Loan Duration: ");
            int t= Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Monthly Compounding: ");
            int n = Convert.ToInt32(Console.ReadLine());

            

            var spObj = new EmiCalculation();

            spObj.p = p;
            spObj.i = i;
            spObj.t = t;
            spObj.n = n;

            var res=spObj.GetEmiResult();

            Console.WriteLine($"Monthly Emi: {res.calculate} INR");




        }

    }
}
