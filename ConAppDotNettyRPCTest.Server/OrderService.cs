using System;
using System.Collections.Generic;
using System.Text;

namespace ConAppDotNettyRPCTest.Server
{
    public class OrderService : IOrderService
    {
        public decimal CalculateFinalOrderSum(long userId, decimal originalSum)
        {
            return 666;
        }
    }
}
