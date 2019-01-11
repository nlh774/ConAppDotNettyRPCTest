using System;
using System.Collections.Generic;
using System.Text;

namespace ConAppDotNettyRPCTest.Server
{
    public interface IHello
    {
        string SayHello(string msg);
    }
}
