using System;

namespace DecoratorSample
{
    class Program
    {
        static void Main(string[] args)
        {
            VisualComponentBase component, componentSB, componentBB;          //使用抽象构件定义
            component = new Window();                                   //创建具体构件对象
            componentSB = new ScrollBarDecorator(component);             //定义装饰后的构件
            componentBB = new BlackBorderDecorator(componentSB);

            componentBB.Display();
            Console.Read();
        }
    }
}
