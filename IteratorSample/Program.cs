using System;
using System.Collections.Generic;

namespace IteratorSample
{
    class Program
    {
        static void Main(string[] args)
        {
            List<object> products = new List<object>
            {
                "倚天剑",
                "屠龙刀",
                "断肠草",
                "葵花宝典"
            };

            AbstractObjectList list;
            IAbstractIterator iterator;

            list = new ProductList(products);
            iterator = list.CreateIterator();

            Console.WriteLine("正向遍历：");
            while (!iterator.IsLast())
            {
                Console.Write(iterator.GetNextItem() + ",");
                iterator.Next();
            }
            Console.WriteLine();
            Console.WriteLine("-----------------");
            Console.WriteLine("逆向遍历：");
            while (!iterator.IsFirst())
            {
                Console.Write(iterator.GetPreviousItem() + ",");
                iterator.Previous();
            }

            Console.Read();
        }
    }
}
