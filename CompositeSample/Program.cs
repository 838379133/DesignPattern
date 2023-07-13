using System;

namespace CompositeSample
{
    class Program
    {
        static void Main(string[] args)
        {
            //针对抽象构件编程
            FileBase file1, file2, file3, file4, file5, folder1, folder2, folder3, folder4;

            folder1 = new Folder("我的资料");
            folder2 = new Folder("图像文件");
            folder3 = new Folder("文本文件");
            folder4 = new Folder("视频文件");

            file1 = new ImageFile("小龙女.JPG");
            file2 = new ImageFile("张无忌>JPG");
            file3 = new TextFile("九阴真经.txt");
            file4 = new TextFile("葵花宝典.doc");
            file5 = new VideoFile("神雕侠女.rmvb");

            folder2.Add(file1);
            folder2.Add(file2);
            folder3.Add(file3);
            folder3.Add(file4);
            folder4.Add(file5);

            folder1.Add(folder2);
            folder1.Add(folder3);
            folder1.Add(folder4);

            //从我的资料结点开始进行杀毒
            folder1.KillVirus();
            Console.Read();
        }
    }
}
