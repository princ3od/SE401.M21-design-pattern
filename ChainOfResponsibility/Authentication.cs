using System;
using System.Collections.Generic;

namespace ChainOfResponsibility
{
    public class Authentication : IMiddleware
    {
        public IMiddleware Next { get; set; }

        readonly List<String> validCodes = new List<string> { "SE401.M21" };
        public void Invoke(object param)
        {
            Console.WriteLine("Authenticating " + param.ToString());
            if (validCodes.Contains(param.ToString()))
            {
                Next?.Invoke("SE401.M21");
            }
        }
    }
}