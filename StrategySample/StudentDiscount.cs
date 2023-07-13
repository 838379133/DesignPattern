using System;
using System.Collections.Generic;
using System.Text;

namespace StrategySample
{
    class StudentDiscount : IDiscount
    {
        private const double DISCOUNT = 0.8;
        public double Calculate(double price)
        {
            Console.WriteLine("学生票：");
            return price * DISCOUNT;
        }
    }
}
