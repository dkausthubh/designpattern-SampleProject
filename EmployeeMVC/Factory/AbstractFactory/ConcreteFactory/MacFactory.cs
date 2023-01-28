using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using static EmployeeMVC.Factory.AbstractFactory.Enumerations;

namespace EmployeeMVC.Factory.AbstractFactory
{
    public class MacFactory:IComputerFactory
    {
        public IBrand Brand()
        {
            return new MAC();
        }

        public IProcessors Processor()
        {
            return new I7();
        }

        public virtual ISystemType SystemType()
        {
            return new Desktop();
        }
    }
    public class MACLaptopFactory : MacFactory
    {
        public override ISystemType SystemType()
        {
            return new Laptop();
        }
    }
}