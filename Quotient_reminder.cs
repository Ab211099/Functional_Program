﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_core_programs
{
    internal class Quotient_reminder
    {
        public static void QuoReminder()
        {
            Console.WriteLine("Enter the value of dividend");
            int numdividend = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the value of divisor");
            int divisor = Convert.ToInt32(Console.ReadLine());

            int numquotient = numdividend / divisor;
            int numremainder = numdividend % divisor;
            Console.WriteLine("quotient = " + numquotient);
            Console.WriteLine("remainder = " + numremainder);
        }
    }
}
