using System;
using System.Collections.Generic;
using System.Text;

namespace FlyweightSample
{
    abstract class IgochessmanBase //抽象享元类
    {
        public abstract string GetColor();

        public void Display(Coordinates coord)
        {
            Console.WriteLine("棋子颜色：{0},棋子位置：{1},{2}", this.GetColor(), coord.X, coord.Y);
        }
    }
}
