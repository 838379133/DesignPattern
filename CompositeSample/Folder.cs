using System;
using System.Collections.Generic;
using System.Text;

namespace CompositeSample
{
    class Folder: FileBase
    {
        //定义集合fileList,用于存储FileBase类型的成员
        private List<FileBase> fileList = new List<FileBase>();
        //private string name;

        public Folder(string name) : base(name)
        {

        }

        public override void Add(FileBase file)
        {
            fileList.Add(file);
        }

        public override void Remove(FileBase file) 
        {
            fileList.Remove(file);
        }

        public override FileBase GetChild(int i)    
        {
            return (FileBase)fileList[i];
        }

        public override void KillVirus()
        {
            //模拟杀毒
            Console.WriteLine("***对文件夹'{0}'进行杀毒", mName);

            //递归调用成员构件的killVirus()方法
            foreach(object obj in fileList)
            {
                ((FileBase)obj).KillVirus();
            }
        }
    }
}
