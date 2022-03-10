using System;

namespace Builder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StudentBuilder studentBuilder = new StudentConcreteBuilder()
                .SetFirstName("Nguyen")
                .SetLastName("Son Tung");

            Console.WriteLine(studentBuilder.Build().ToString());
        }
    }
}
