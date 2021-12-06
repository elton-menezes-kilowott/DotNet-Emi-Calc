using System;
using System.Collections.Generic;   
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNet_Emi_Calc
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter loan amount");
            int loanAmount = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter rate of interest");
            double ROI = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter No of Years");
            int time = Convert.ToInt32(Console.ReadLine());
           
            var emi = new Emi();
            emi.Amount = loanAmount;
            emi.ROI = ROI;
            emi.Time = time;

            double EMI = emi.Calc_Emi();
            Console.WriteLine("Emi is : " + EMI);
        }
    }
}

    
