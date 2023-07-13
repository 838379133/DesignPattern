using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeSample
{
    class PNGImage : ImageBase//扩充抽象类
    {
        public override void ParseFile(string fileName)
        {
            //模拟解析PNG文件并获得一个像素矩阵对象m;
            Matrix m = new Matrix();
            mImage.DoPaint(m);
            Console.WriteLine("{0},格式为PNG", fileName);
        }
    }
}
