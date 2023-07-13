using System;
using System.Collections.Generic;
using System.Text;

namespace CompositeSample
{
    abstract class FileBase //抽象文件类 抽象构件
    {
        protected string mName;

        public FileBase(string name)
        {
            mName = name;
        }

        public abstract void Add(FileBase file);
        public abstract void Remove(FileBase file);
        public abstract FileBase GetChild(int i);
        public abstract void KillVirus();
    }
}
