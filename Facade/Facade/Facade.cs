using Facade.Subsystems;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    internal class Facade
    {
        private Subsystem1 subsystem1;
        private Subsystem2 subsystem2;
        private Subsystem3 subsystem3;

        public Facade()
        {
            subsystem1 = new Subsystem1();
            subsystem2 = new Subsystem2();
            subsystem3 = new Subsystem3();
        }

        public void OperationFacade()
        {
            Console.WriteLine("Facade: OperationFacade");
            subsystem1.Operation1();
            subsystem2.Operation2();
            subsystem3.Operation3();
        }
    }
}
