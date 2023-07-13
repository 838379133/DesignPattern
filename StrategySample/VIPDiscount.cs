using System;
using System.Collections.Generic;
using System.Text;

namespace StrategySample
{
    class VIPDiscount : IDiscount
    {
        private const double DISCOUNT = 0.5;
        public double Calculate(double price)
        {
            Console.WriteLine("VIP票：");
            Console.WriteLine("增加积分");
            return price * DISCOUNT;
        }

    }
}
