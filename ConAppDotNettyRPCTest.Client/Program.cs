using Coldairarrow.DotNettyRPC;
using System;

namespace ConAppDotNettyRPCTest.Client
{
    class Program
    {
        static void Main(string[] args)
        {
            IHello client = RPCClientFactory.GetClient<IHello>("127.0.0.1", 9999);
            var msg1 = client.SayHello("Hello1");
            Console.WriteLine(msg1);

            var msg2 = client.SayHello("Hello2");
            Console.WriteLine(msg2);

            decimal prize = 100.1M;
            IOrderService orderService = RPCClientFactory.GetClient<IOrderService>("127.0.0.1", 9999);
            var sum1 = orderService.CalculateFinalOrderSum(500, prize);
            Console.WriteLine(sum1);

            var sum2 = orderService.CalculateFinalOrderSum(11000, 1000);
            Console.WriteLine(sum2);

            Console.ReadLine();
        }
    }
}
