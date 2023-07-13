using System;
using System.Collections.Generic;
using System.Text;

namespace StrategySample
{
    class ChildrenDiscount : IDiscount
    {
        private const double DISCOUNT = 10;
        public double Calculate(double price)
        {
            Console.WriteLine("儿童票：");
            return price - DISCOUNT;
        }
    }
}
