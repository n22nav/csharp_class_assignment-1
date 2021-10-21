using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_and_O
{
    class Q1
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter total credit amount");
            double credit = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the monthly payment amount");
            double emi = double.Parse(Console.ReadLine());
            int i = 1;
            double pay = 0;


            while (credit > emi)
            {
                pay += emi;
                credit = 1.015 * credit - emi;
                Console.WriteLine("Month {0}:\tBalance: {1}\tPayment: {2}", i, credit, pay);
                i++;
            }
            Console.WriteLine("Month {0}:\tBalance: {1}\tPayment: {2}", i, credit, arg2:pay);

        }
    }
}
