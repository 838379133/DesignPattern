using System;
using System.Configuration;
using System.Reflection;

namespace BuilderSample
{
    class Program
    {
        static void Main(string[] args)
        {
            //ActorBuliderBase ab;//抽象建造者
            //string builderType = ConfigurationManager.AppSettings["builder"];
            ////反射生成对象
            //ab = (ActorBuliderBase)Assembly.Load("BuilderSample").CreateInstance(builderType);

            ActorBuliderBase ab = new AngelBuilder();
           
            ActorController ac = new ActorController();
            Actor actor;
            actor = ac.Construct(ab);

            Console.WriteLine("{0}的外观：", actor.Type);
            Console.WriteLine("性别：{0}", actor.Sex);
            Console.WriteLine("面容：{0}", actor.Face);
            Console.WriteLine("服装：{0}", actor.Costume);
            Console.WriteLine("发型：{0}", actor.Hairstyle);
            Console.Read();
        }
    }
}
