using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorSample
{
    class ComponentDecorator : VisualComponentBase //抽象装饰类
    {
        private readonly VisualComponentBase mComponent;//维持对抽象构件类型对象的引用

        //注入抽象构件类型的对象
        public ComponentDecorator(VisualComponentBase component)
        {
            mComponent = component;
        }

        public override void Display()
        {
            mComponent.Display();
        }
    }
}
