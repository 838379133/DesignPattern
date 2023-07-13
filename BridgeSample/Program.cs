using System;
using System.Configuration;
using System.Reflection;

namespace BridgeSample
{
    class Program
    {
        static void Main(string[] args)
        {
            //ImageBase image;
            //IImage imp;

            ////读取配置文件
            //string imageType = ConfigurationManager.AppSettings["image"];
            //string osType = ConfigurationManager.AppSettings["os"];

            ////反射生成对象
            //image = (ImageBase)Assembly.Load("BridgeSample").CreateInstance(imageType);
            //imp = (IImage)Assembly.Load("BridgeSample").CreateInstance(osType);

            ImageBase image = new JPGImage();
            IImage imp = new WindowsImp();

            image.SetImageImp(imp);
            image.ParseFile("中国地图");
            Console.Read();
        }
    }
}
