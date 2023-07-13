using System;
using System.Collections.Generic;
using System.Text;

namespace FlyweightSample
{
    class BlackIgoChessman : IgochessmanBase //具体享元类
    {
        public override string GetColor()
        {
            return "黑色";
        }
    }
}
