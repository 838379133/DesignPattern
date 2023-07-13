using System;

namespace FlyweightSample
{
    class Program
    {
        static void Main(string[] args)
        {
            IgochessmanBase black1, black2, white1, white2;
            IgoChessmanFactory factory;

            //获取享元工厂对象
            factory = IgoChessmanFactory.GetmInstance();

            //通过享元获取2颗黑子
            black1 = factory.GetIgochessman("b");
            black2 = factory.GetIgochessman("b");
            Console.WriteLine("判断两颗黑子是否相同:" + (black1 == black2));

            //通过享元获取2颗白子
            white1 = factory.GetIgochessman("w");
            white2 = factory.GetIgochessman("w");
            Console.WriteLine("判断两颗白子是否相同:" + (white1 == white2));

            black1.Display(new Coordinates(1, 2));
            black2.Display(new Coordinates(3, 4));
            white1.Display(new Coordinates(2, 5));
            white2.Display(new Coordinates(2, 4));

            Console.Read();

        }
    }
}
