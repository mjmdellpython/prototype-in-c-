using System;

namespace prototypeDesignePattren
{
    class Program
    {
        // As prototype is just make clone (copy) of the original class
        static void Main(string[] args)
        {
            Console.WriteLine("prototype start ... ");
            ConsertProp1 cp1a = new ConsertProp1("white");
            ConsertProp1 cp1b = (ConsertProp1)cp1a.clone();// should keep casting
            System.Console.WriteLine("Clone : {0}", cp1b.Id);

            ConsertProp2 cp2a = new ConsertProp2("blue");
            ConsertProp2 cp2b = (ConsertProp2)cp2a.clone();
            System.Console.WriteLine("clone : {0}", cp2b.Id);

            

        }
    }
}
