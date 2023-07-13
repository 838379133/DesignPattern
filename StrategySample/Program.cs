using System;

namespace StrategySample
{
    class Program
    {
        static void Main(string[] args)
        {
            MovieTicket mt = new MovieTicket();
            double OriginalPrice = 60.0;
            double CurrentPrice;

            mt.Price = OriginalPrice;
            Console.WriteLine("原始价为;{0}", OriginalPrice);
            Console.WriteLine("---------------------------");

            IDiscount discount = new StudentDiscount();
            mt.SetDiscount(discount);

            CurrentPrice = mt.Price;
            Console.WriteLine("折扣后的价格为：{0}", CurrentPrice);
            Console.Read();
        }
    }
}
