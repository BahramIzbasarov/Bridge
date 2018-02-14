using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    class ConcreteImplementorHardDisc : Implementor
    {
        public override void Operation()
        {
            Console.WriteLine("TERRA MOVIE SERVER 10TB 4-Bay Rack-mountable Network Storage");
        }
    }
}
