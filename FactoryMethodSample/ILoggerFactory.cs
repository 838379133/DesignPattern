using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethodSample
{
    interface ILoggerFactory
    {
        ILogger CreateLogger();//抽象工厂方法
    }
}
