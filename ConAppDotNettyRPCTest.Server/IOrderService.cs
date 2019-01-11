using System;
using System.Collections.Generic;
using System.Text;

namespace ConAppDotNettyRPCTest.Server
{
    public interface IOrderService
    {
        decimal CalculateFinalOrderSum(long userId, decimal originalSum);
    }
}
