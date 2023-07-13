using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactorySample
{
    class SummerComboBox : IComboBox 
    {
        public void Display()
        {
            Console.WriteLine("显示蓝色边框的组合框");
        }
    }
}
