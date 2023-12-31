﻿using System;

namespace VisitorSample
{
    class Program
    {
        static void Main(string[] args)
        {
            EmployeeList list = new EmployeeList();
            IEmployee fte1, fte2, fte3, pte1, pte2;

            fte1 = new FulltimeEmployee("张无忌", 3200.00, 45);
            fte2 = new FulltimeEmployee("杨过", 2000.00, 40);
            fte3 = new FulltimeEmployee("段誉", 2400.00, 38);
            pte1 = new ParttimeEmployee("洪七公", 80.00, 20);
            pte2 = new ParttimeEmployee("郭靖", 60.00, 18);

            list.AddEmployee(fte1);
            list.AddEmployee(fte2);
            list.AddEmployee(fte3);
            list.AddEmployee(pte1);
            list.AddEmployee(pte2);

            DepartmentBase dep = new HrDepartment();
            list.Accpet(dep);

            Console.Read();
        }
    }
}
