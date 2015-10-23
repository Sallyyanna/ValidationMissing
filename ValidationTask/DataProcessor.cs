using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ValidationTask
{
    public class DataProcessor
    {
        public void SetUserName(string name)
        {
            if (name.Length == 0)
            {
                throw new Exception("Invalid username");
            }
        }


        public Decimal MonthlySalaryFromAnnual(decimal annual)
        {
            Decimal monthly = annual / 12.0m;
            if (monthly >= 0 && monthly <= 200000000)
            {
                return monthly;
            }
            else
            {
                throw new Exception("Invalid salary amount");
            }
        }
    }
}