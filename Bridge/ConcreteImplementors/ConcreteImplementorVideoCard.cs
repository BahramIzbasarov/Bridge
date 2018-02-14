using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    class ConcreteImplementorVideoCard : Implementor
    {
        public override void Operation()
        {
            Console.WriteLine("NVIDIA GeForce GTX 1080 Ti 11GB GDDR5X PCI Express 3.0 ");
        }
    }
}
