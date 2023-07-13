using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactorySample
{
    class SummerTextField : ITextField
    {
        public void Display()
        {
            Console.WriteLine("显示蓝色边框的文本框");
        }
    }
}
