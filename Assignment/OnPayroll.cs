﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    internal class OnPayroll:Employee
    {
        byte exp;
        double basicSalary;
        DateTime joiningDate;
        double hra, da, netSalary;
        int pf;
        public override void GetDetails()
        {
            base.GetDetails();
            Console.WriteLine("Enter Exp");
            exp = Convert.ToByte(Console.ReadLine());
            Console.WriteLine("Enter the basic Salary");
            basicSalary = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Joining Date");
            joiningDate = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Enter Hra: ");
            hra = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter The DA");
            da = double.Parse(Console.ReadLine());
            CalculatePayment(basicSalary, exp);
            DisplayDetails();

        }
        public void CalculatePayment(double basicsalary, byte exp)
        {

            if (exp > 10)
            {
                da = (10 / 100) * basicsalary;
                hra = (8.5 / 100) * basicsalary;
                pf = 6200;
                netSalary = ((da* basicSalary) + ((hra * basicSalary) - pf));
            }
            else if (exp > 7 && exp < 10)
            {
                da = (7 / 100) * basicsalary;
                hra = (6.5 / 100) * basicsalary;
                pf = 4100;
                netSalary = ((da * basicSalary) + ((hra * basicSalary) - pf));
            }
            else if (exp > 5 && exp < 7)
            {
                da = (4.1 / 100) * basicsalary;
                hra = (3.8 / 100) * basicsalary;
                pf = 1800;
                netSalary = ((da * basicSalary) + ((hra * basicSalary) - pf));
            }
            else
            {
                da = (1.9 / 100) * basicsalary;
                hra = (2.0 / 100) * basicsalary;
                pf = 1200;
                netSalary = ((da * basicSalary) + ((hra * basicSalary) - pf));
            }
        }
        public void DisplayDetails()
        {
            Console.WriteLine("The Basic Salary is ", basicSalary);
            Console.WriteLine("Da ", da);
            Console.WriteLine("Hra is ", hra);
            Console.WriteLine("total salary is ", netSalary);
        }
    }
}
