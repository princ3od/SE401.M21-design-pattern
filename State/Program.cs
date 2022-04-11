using System;
using StatePattern;

namespace RefactoringGuru.DesignPatterns.State.Conceptual
{

    class Program
    {
        static void Main(string[] args)
        {
            // The client code.
            var context = new Context(new ConcreteStateA());
            context.Request1();
            context.Request2();
        }
    }
}