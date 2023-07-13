using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverSample
{
    class ConcreteAllControlCenter : AllControlCenter //具体目标类
    {
        public ConcreteAllControlCenter(string armyName)
        {
            Console.WriteLine("{0}军队组建成功！", armyName);
            Console.WriteLine("-----------------");
            mArmyName = armyName;
        }

        //实现通知方法
        public override void NotifyObserver(string name)
        {
            Console.WriteLine("{0}军队紧急通知，盟友{1}遭受敌人攻击！", mArmyName, name);
            //遍历观察者集合,调用每一个盟友的支援方法
            foreach(object obs in players)
            {
                if (!((IObserver)obs).Name.Equals(name))
                {
                    ((IObserver)obs).Help();
                }
            }
        }
    }
}
