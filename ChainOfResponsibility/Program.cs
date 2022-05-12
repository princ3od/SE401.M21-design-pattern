using System;

namespace ChainOfResponsibility
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Middleware middleware = new Middleware();
            middleware.Use(new Logging());
            middleware.Use(new Authentication());
            middleware.Use(new Process());

            Handle("SE401.M21", middleware);
        }

        static void Handle(object param, Middleware middleware)
        {
            Console.WriteLine("Starting...");
            middleware.Invoke(param);
            Console.WriteLine("Done!");
        }

    }
}