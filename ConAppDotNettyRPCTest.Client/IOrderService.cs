using System;
using System.Collections.Generic;
using System.Text;

namespace ConAppDotNettyRPCTest.Client
{
    public interface IOrderService
    {
        double CalculateFinalOrderSum(long userId, double originalSum);
    }
}
