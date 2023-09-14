﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module5
{
    internal class Utilities
    {
        public static int calculateYearlyWage(int monthlyWage, int numberOfMonthsWorked)
        {
            //Console.WriteLine($"Yearly wage:{monthlyWage * numberOfMonthsWorked}");
            //return monthlyWage + numberOfMonthsWorked;
            if (numberOfMonthsWorked == 12)
            {
                return monthlyWage * (numberOfMonthsWorked + 1);
            }
            return monthlyWage * numberOfMonthsWorked;
        }
    }
}