using System;
using System.Configuration;
using System.Reflection;

namespace FactoryMethodSample
{
    class Program
    {
        static void Main(string[] args)
        {
            ILoggerFactory factory;
            ILogger logger;
            //factory = new FileLoggerFactory();
            //logger = factory.CreateLogger();
            //logger.WriteLog();

            //读取配置文件
            string factoryString = ConfigurationManager.AppSettings["factory"];
            //反射生成对象
            factory = (ILoggerFactory)Assembly.Load("FactoryMethodSample").CreateInstance(factoryString);
            logger = factory.CreateLogger();
            logger.WriteLog();

            Console.Read();
        }
    }
}
