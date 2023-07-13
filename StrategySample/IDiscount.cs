using System;
using System.Collections.Generic;
using System.Text;

namespace StrategySample
{
    interface IDiscount
    {
        double Calculate(double price);
    }
}
