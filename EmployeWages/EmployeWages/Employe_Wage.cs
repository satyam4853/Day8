using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeWages
{
    class Employe_Wage
    {
       public int Wage_Per_Hr;
       public int Employee_Hrs;
       public int EmpWage;
       public int Monthly_Wage;
       public int Count;
       public int numOfHrsWorked;
       public int daysWorked;
        public void EmployeeDetails()
        {
            Wage_Per_Hr = 20;
            Monthly_Wage = 0;
            Count = 0;
            numOfHrsWorked = 0;
            daysWorked = 0;
            EmpWage = 0;
        }
        public void EmployeeCheck()
        {
            Random rand = new Random();
            while (numOfHrsWorked <= 100 && daysWorked <= 20)
            {
                int num = rand.Next(0, 3);
                Console.WriteLine("Random number is :" + num);
                switch (num)
                {
                    case 1:
                        Console.WriteLine("Employee is full time present");
                        Employee_Hrs = 8;
                        numOfHrsWorked += Employee_Hrs;
                        daysWorked++;
                        break;
                    case 2:
                        Console.WriteLine("Employee is part time present");
                        Employee_Hrs = 4;
                        numOfHrsWorked += Employee_Hrs;
                        daysWorked++;
                        break;
                    default:
                        Console.WriteLine("Employee is absent");
                        Employee_Hrs = 0;
                        break;

                }
                Console.WriteLine("Number of hours worked" + numOfHrsWorked);
                EmpWage = Employee_Hrs * Wage_Per_Hr;
                Monthly_Wage += EmpWage;
                Count++;
            }
            Console.WriteLine("Number of times counter ran" + Count);
            Console.WriteLine("Days worked " + daysWorked);
            Console.WriteLine("The total employee wage is " + Monthly_Wage);

        }
    }
}

    
