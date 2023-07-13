using System;

namespace CoRSample
{
    class Program
    {
        static void Main(string[] args)
        {
            ApproverBase Zhangwj, Yangg, Guoj, meeting;
            Zhangwj = new Director("张无忌");
            Yangg = new VicePresident("杨过");
            Guoj = new President("郭靖");
            meeting = new Congress("董事会");

            //创建职责链
            Zhangwj.SetSuccessor(Yangg);
            Yangg.SetSuccessor(Guoj);
            Guoj.SetSuccessor(meeting);

            //创建多个采购单对象并递交请求
            PurchaseRequest pr1 = new PurchaseRequest(45000, 10001, "购买倚天剑");
            Zhangwj.ProcessRequest(pr1);

            PurchaseRequest pr2 = new PurchaseRequest(800000, 10002, "金刚经");
            Zhangwj.ProcessRequest(pr2);

            Console.Read();
        }
    }
}
