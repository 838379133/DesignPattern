using System;
using System.Collections.Generic;
using System.Text;

namespace VisitorSample
{
    class FulltimeEmployee : IEmployee //具体元素
    {
        //private string mName;           //员工姓名
        private readonly double mWeeklyWage;      //员工周薪
        private readonly int mWorkTime;          //工作时间

        public FulltimeEmployee(string name, double weeklywage, int worktime) 
        {
            Name = name;
            mWeeklyWage = weeklywage;
            mWorkTime = worktime;
        }

        public string Name { get; private set; }
        

        public double WeeklyWage
        {
            get { return mWeeklyWage; }
        }

        public int WorkTIme
        {
            get { return mWorkTime; }
        }

        public void Accept(DepartmentBase handler)
        {
            handler.Visit(this);    //调用访问者的访问方法
        }
    }
}
