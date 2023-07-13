using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorSample
{
    class Window : VisualComponentBase //具体构件类
    {
        public override void Display()
        {
            Console.WriteLine("显示窗体！");
        }
    }
}
