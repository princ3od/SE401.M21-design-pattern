using System;

namespace ChainOfResponsibility
{
    public class Logging : IMiddleware
    {
        public IMiddleware Next { get; set; }

        public void Invoke(object param)
        {
            Console.WriteLine("Logging " + param.ToString());
            Next?.Invoke(param);
        }
    }
}