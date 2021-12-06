using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNet_Emi_Calc
{
    public class Emi
    {
        public int Amount { get; set; }
        public double ROI { get; set; }
        public int Time { get; set; }

        public double Calc_Emi()
        {
            double r = ROI / (12 * 100);
            double upperLogic = Math.Pow(1 + r, Time * 12);
            double Emi = Amount * r * (upperLogic / (upperLogic - 1));
            return Emi;
        }
        
    }
}
