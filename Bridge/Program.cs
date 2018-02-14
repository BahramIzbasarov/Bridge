using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    class Program
    {
        static void Main(string[] args)
        {
            Abstraction library = new RefinedAbstraction();

            library.Implementor = new ConcreteImplementorCPU();
            library.Operation();

            library.Implementor = new ConcreteImplementorVideoCard();
            library.Operation();

            library.Implementor = new ConcreteImplementorHardDisc();
            library.Operation();

            Console.Read();
        }
    }
}
