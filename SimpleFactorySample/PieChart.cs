﻿using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleFactorySample
{
    class PieChart : IChart
    {
        public PieChart()
        {
            Console.WriteLine("创建饼状图！");
        }
        public void Display()
        {
            Console.WriteLine("显示饼状图!");
        }
    }
}
