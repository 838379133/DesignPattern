using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactorySample
{
    class SummerButton : IButton
    {
        public void Display()
        {
            Console.WriteLine("显示浅蓝色的按钮");
        }
    }
}
