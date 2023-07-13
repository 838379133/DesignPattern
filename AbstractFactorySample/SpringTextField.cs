using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactorySample
{
    class SpringTextField : ITextField
    {
        public void Display()
        {
            Console.WriteLine("显示绿色边框的文本框");
        }
    }
}
