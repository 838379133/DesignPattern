using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverSample
{
    class Player : IObserver
    {
        private readonly string mName;

        public Player(string name)
        {
            mName = name; 
        }

        public string Name
        {
            get { return mName; }
        }

        //支援盟友方法
        public void Help()
        {
            Console.WriteLine("坚持住，{0}来救你！", mName);
        }

        //遭受攻击方法的实现
        public void BeAttacked(AllControlCenter acc)
        {
            Console.WriteLine("{0}被攻击", mName);
            acc.NotifyObserver(mName);
        }
    }
}
