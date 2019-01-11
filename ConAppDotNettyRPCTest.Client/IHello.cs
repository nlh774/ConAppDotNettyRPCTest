using System;
using System.Collections.Generic;
using System.Text;

namespace ConAppDotNettyRPCTest.Client
{
    public interface IHello
    {
        string SayHello(string msg);
    }
}
