using System;
using System.Collections.Generic;
using System.Text;

namespace ConAppDotNettyRPCTest.Client
{
    public interface IOrderService
    {
        decimal CalculateFinalOrderSum(long userId, decimal originalSum);
    }
}
