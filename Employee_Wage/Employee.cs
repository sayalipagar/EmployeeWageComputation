﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_Wage
{
    internal class Employee
    {
        const int IS_FULL_TIME = 0, IS_PART_TIME = 1, WAGE_PER_HR = 20, FULL_TIME_HR = 8, PART_TIME_HR = 4;
        int totalEmpWage;
        public void CalculateEmpWage()
        {
            Random random = new Random();
            int empCheck = random.Next(0, 3);
            if (empCheck == 0)
           {
                totalEmpWage = WAGE_PER_HR * FULL_TIME_HR;
                Console.WriteLine(totalEmpWage);
            }
            if (empCheck == IS_PART_TIME)
            {
                totalEmpWage = WAGE_PER_HR * PART_TIME_HR;
            }
           
        }


    }
}
