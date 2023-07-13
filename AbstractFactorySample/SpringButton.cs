using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactorySample
{
    class SpringButton : IButton
    {
        public void Display()
        {
            Console.WriteLine("显示绿色的按钮");
        }
    }
}
