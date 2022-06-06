using System;

namespace Visitor
{
    class Program
    {
        static void Main(string[] args)
        {
            Human warrior = new Warrior();
            Human wizard = new Wizard();

            Monster dogie = new CuteDogie();
            Monster dracula = new Dracula();

            Console.WriteLine("---- Hit dogie ----");
            warrior.Hit(dogie);
            wizard.Hit(dogie);

            Console.WriteLine("---- Hit dracula ----");
            warrior.Hit(dracula);
            wizard.Hit(dracula);
        }
    }
}
