using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverSample
{
    interface IObserver
    {
        string Name
        {
            get;
        }
        void Help();                            //声明支援盟友方法
        void BeAttacked(AllControlCenter acc);  //声明遭受攻击方法
    }
}
