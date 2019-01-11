using Coldairarrow.DotNettyRPC;
using System;

namespace ConAppDotNettyRPCTest.Server
{
    class Program
    {
        static void Main(string[] args)
        {
            RPCServer rPCServer = new RPCServer(9999);
            rPCServer.RegisterService<IHello, Hello>();
            rPCServer.RegisterService<IOrderService, OrderService>();
            rPCServer.Start();

            Console.WriteLine(".netCore ecf DotNettyRPC start!");
            Console.ReadLine();
            
        }
    }
}
