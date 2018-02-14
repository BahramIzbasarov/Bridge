using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    class ConcreteImplementorCPU : Implementor
    {
        public override void Operation()
        {
            Console.WriteLine("Core™ I7-6950X 3GHz Processor");
        }
    }
}
