using System;

namespace Proxy
{
    class Program
    {
        static void Main(string[] args)
        {
            Video image = new ProxyVideo("Design Pattern.mp4");

            image.Display();
            Console.WriteLine("----After loading first time----");
            image.Display();
        }
    }
}
