using System;
using System.Collections.Generic;
using System.Text;

namespace VisitorSample
{
    class ParttimeEmployee : IEmployee //具体元素
    {
        private readonly string mName;        //员工姓名
        private readonly double mHourWage;    //员工时薪
        private readonly int mWorkTime;       //工作时间

        public ParttimeEmployee(string name, double hourwage, int worktime)
        {
            mName = name;
            mHourWage = hourwage;
            mWorkTime = worktime;
        }

        public string Name
        {
            get { return mName; }
            //set { mName = value; }
        }

        public double HourWage
        {
            get { return mHourWage; }
            //set { mHourWage = value; }
        }

        public int WorkTIme
        {
            get { return mWorkTime; }
            //set { mWorkTime = value; }
        }

        public void Accept(DepartmentBase handler)
        {
            handler.Visit(this);
        }
    }
}
