using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleFactorySample
{
    class LineChart : IChart
    {
        public LineChart()
        {
            Console.WriteLine("创建折线图!");
        }
        public void Display()
        {
            Console.WriteLine("显示折线图!");
        }
    }
}
