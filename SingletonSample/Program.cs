using System;
using System.Collections;

namespace SingletonSample
{
    class Program
    {
        static void Main(string[] args)
        {
            //创建4个LoadBalancer对象
            LoadBalancer balancer1, balancer2, balancer3, balancer4;
            balancer1 = LoadBalancer.GetLoadBalancer();
            balancer2 = LoadBalancer.GetLoadBalancer();
            balancer3 = LoadBalancer.GetLoadBalancer();
            balancer4 = LoadBalancer.GetLoadBalancer();

            //半段服务器负载均衡器是否相同
            if(balancer1 == balancer2 && balancer2 == balancer3 && balancer3 == balancer4)
            {
                Console.WriteLine("服务器负载均衡器具有唯一性");
            }

            //增加服务器
            balancer1.AddServer("server 1");
            balancer2.AddServer("server 2");
            balancer3.AddServer("server 3");
            balancer4.AddServer("server 4");
            
            //模拟客户端请求的分发
            for(int i = 0; i < 10; i++)
            {
                string server = balancer1.Getserver();
                Console.WriteLine("分发请求服务器:" + server);
            }
            Console.Read();
        }
    }
}
