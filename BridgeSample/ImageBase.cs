using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeSample
{
    abstract class ImageBase//抽象类
    {
        protected IImage mImage;

        //注入实现类接口对象
        public void SetImageImp(IImage image)
        {
            mImage = image;
        }

        public abstract void ParseFile(string fileName);
    }
}
