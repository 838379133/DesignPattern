using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorSample
{
    class TextBox : VisualComponentBase //具体构件类
    {
        public override void Display()
        {
            Console.WriteLine("显示文本框！");
        }
    }
}
