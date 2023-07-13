using System;
using System.Collections.Generic;
using System.Text;

namespace MediatorSample
{
    abstract class MediatorBase     //抽象中介类
    {
        public abstract void ComponentChanged(ComponentBase c);
    }
}
