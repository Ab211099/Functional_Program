﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_core_programs
{
    internal class Large_number
    {
        public static void findlargestNumber()
        {
            int num1, num2, num3;
            Console.WriteLine("Enter first number");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second number");
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter third number");
            num3 = Convert.ToInt32(Console.ReadLine());

            if (num1 > num2)
            {
                if (num1 > num3)
                {
                    Console.WriteLine("{0} is Largest", num1);
                }
                else
                {
                    Console.WriteLine("{0} is Largest", num3);
                }
            }
            else if (num2 > num3)
            {
                Console.WriteLine("{0} is Largest", num2);
            }
            else
            {
                Console.WriteLine("{0} is Largest", num3);
            }
        }
    }
}
