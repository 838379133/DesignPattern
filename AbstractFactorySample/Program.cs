using System;
using System.Configuration;
using System.Reflection;

namespace AbstractFactorySample
{
    class Program
    {
        static void Main(string[] args)
        {
            //使用抽象层定义
            ISkinFactory factory = new SpringSkinFactory();
            IButton bt;
            ITextField tf;
            IComboBox cb;
            //string factoryType = ConfigurationManager.AppSettings["factory"];
            ////反射生成对象
            //factory = (ISkinFactory)Assembly.Load("AbstractFactorySample").CreateInstance(factoryType);
            bt = factory.CreateButton();
            tf = factory.CreateTextField();
            cb = factory.CreateComboBox();
            bt.Display();
            tf.Display();
            cb.Display();

            Console.Read();
        }
    }
}
