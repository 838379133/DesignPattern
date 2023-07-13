using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeSample
{
    interface IImage//实现类接口
    {
        void DoPaint(Matrix m);     //显示像素矩阵；
    }
}
