using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorSample
{
    class ScrollBarDecorator : ComponentDecorator //具体装饰类
    {
        public ScrollBarDecorator(VisualComponentBase component) : base(component)
        {
        }
        public override void Display()
        {
            this.SetScrollBar();    //两者顺序问题
            base.Display();
        }
        public void SetScrollBar()
        {
            Console.WriteLine("为构件增加滚动条");
        }
    }
}
