using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorSample
{
    class BlackBorderDecorator : ComponentDecorator //具体装饰类
    {
        public BlackBorderDecorator(VisualComponentBase component) : base(component)
        {
        }

        public override void Display()
        {
            this.SetBlackBorder();
            base.Display();
        }

        public void SetBlackBorder()
        {
            Console.WriteLine("为构件增加黑色边框");
        }

    }
}
