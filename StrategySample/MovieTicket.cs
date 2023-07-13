using System;
using System.Collections.Generic;
using System.Text;

namespace StrategySample
{
    class MovieTicket   //环境类
    {
        private double price;
        private IDiscount Discount;

        //注入一个折扣类的对象
        public void SetDiscount(IDiscount discount)
        {
            Discount = discount;
        }

        public double Price
        {
            get
            {
                return Discount.Calculate(price);
            }
            set { price = value; }
        }
    }
}
