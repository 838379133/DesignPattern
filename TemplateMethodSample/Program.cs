using System;

namespace TemplateMethodSample
{
    class Program
    {
        static void Main(string[] args)
        {
            Account account = new CurrentAccount();
            account.Handle("张无忌", "123456");

            Console.Read();
        }
    }
}
