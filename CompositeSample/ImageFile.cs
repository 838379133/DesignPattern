using System;
using System.Collections.Generic;
using System.Text;

namespace CompositeSample
{
    class ImageFile : FileBase
    {
        public ImageFile(string name) : base(name)
        {

        }

        public override void Add(FileBase file)
        {
            Console.WriteLine("对不起，不支持该方法！");
        }

        public override void Remove(FileBase file)
        {
            Console.WriteLine("对不起，不支持该方法！");
        }

        public override FileBase GetChild(int i)
        {
            Console.WriteLine("对不起，不支持该方法！");
            return null;
        }

        public override void KillVirus()
        {
            //模拟杀毒
            Console.WriteLine("---对图像文件'{0}'进行杀毒", mName);
        }
    }
}
