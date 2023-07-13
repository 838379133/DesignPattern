using System;

namespace FacadeSample
{
    class Program
    {
        static void Main(string[] args)
        {
            EncryptFacade ef = new EncryptFacade();
            ef.FileEncrypt(@"E:\C#\test01\src.txt", @"E:\C#\test01\des.txt");
            Console.Read();
        }
    }
}
