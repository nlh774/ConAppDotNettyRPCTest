using System;
using System.Collections.Generic;
using System.Text;

namespace ConAppDotNettyRPCTest.Server
{
    public class Hello : IHello
    {
        public string SayHello(string msg)
        {
            return msg;
        }
    }
}
