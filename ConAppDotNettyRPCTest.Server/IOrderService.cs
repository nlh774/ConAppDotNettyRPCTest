using System;
using System.Collections.Generic;
using System.Text;

namespace ConAppDotNettyRPCTest.Server
{
    public interface IOrderService
    {
        double CalculateFinalOrderSum(long userId, double originalSum);
    }
}
