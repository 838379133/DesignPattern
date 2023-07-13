using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeSample  //具体实现类
{
    class WindowsImp : IImage
    {
        public void DoPaint(Matrix m)
        {
            Console.Write("在windows操作系统中显示图像：");
        }
    }
}
