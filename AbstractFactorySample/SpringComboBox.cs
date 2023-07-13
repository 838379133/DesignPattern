using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactorySample
{
    class SpringComboBox : IComboBox
    {
        public void Display()
        {
            Console.WriteLine("显示绿色边框的组合框");
        }
    }
}
