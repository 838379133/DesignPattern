using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverSample
{
    abstract class AllControlCenter
    {
        protected string mArmyName;  //军队名称
        protected List<IObserver> players = new List<IObserver>();  //定义集合存储军队成员

        //注册方法
        public void Join(IObserver obs)
        {
            Console.WriteLine("{0}加入{1}战队！", obs.Name, mArmyName);
            players.Add(obs);
        }

        //注销方法
        public void Quit(IObserver obs)
        {
            Console.WriteLine("0}推出{1}战队！", obs.Name, mArmyName);
            players.Remove(obs);
        }

        //声明抽象通知方法
        public abstract void NotifyObserver(string name);
    }
}
