using System;

namespace ChainOfResponsibility
{
    public class Process : IMiddleware
    {
        public IMiddleware Next { get; set; }

        public void Invoke(object param)
        {
            Console.WriteLine("Processing " + param.ToString());
            Next?.Invoke("SE401.M21");
        }
    }
}