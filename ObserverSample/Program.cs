using System;

namespace ObserverSample
{
    class Program
    {
        static void Main(string[] args)
        {
            //定义观察目标
            AllControlCenter acc;
            acc = new ConcreteAllControlCenter("金庸群侠");

            //定义4个观察对象
            IObserver player1, player2, player3, player4;

            player1 = new Player("杨过");
            acc.Join(player1);

            player2 = new Player("令狐冲");
            acc.Join(player2);

            player3 = new Player("张无忌");
            acc.Join(player3);

            player4 = new Player("段誉");
            acc.Join(player4);

            //某成员受到攻击 触发联动
            player1.BeAttacked(acc);

            Console.Read();
        }
    }
}
