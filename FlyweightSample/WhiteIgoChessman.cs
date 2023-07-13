using System;
using System.Collections.Generic;
using System.Text;

namespace FlyweightSample
{
    class WhiteIgoChessman : IgochessmanBase //具体享元类
    {
        public override string GetColor()
        {
            return "白色";
        }
    }
}
