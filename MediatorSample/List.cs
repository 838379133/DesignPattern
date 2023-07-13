using System;
using System.Collections.Generic;
using System.Text;

namespace MediatorSample
{
    class List : ComponentBase
    {
        public override void Update()
        {
            Console.WriteLine("列表框增加一项：张无忌");
        }
        public void Select()
        {
            Console.WriteLine("列表框选中项：小龙女");
        }
    }
}
