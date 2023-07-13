using System;
using System.Collections.Generic;
using System.Text;

namespace FlyweightSample
{
    class Coordinates
    {
        private readonly int mx;
        private readonly int my;

        public Coordinates(int x,int y)
        {
            mx = x;
            my = y;
        }

        public int X
        {
            get { return mx; }
        }

        public int Y
        {
            get { return my; }
        }
    }

}
