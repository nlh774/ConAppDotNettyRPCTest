using System;
using System.Collections.Generic;
using System.Text;

namespace ConAppDotNettyRPCTest.Server
{
    public class OrderService : IOrderService
    {
        public double CalculateFinalOrderSum(long userId, double originalSum)
        {
            return 666;
        }
    }
}
