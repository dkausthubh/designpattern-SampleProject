using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static EmployeeMVC.Factory.AbstractFactory.Enumerations;

namespace EmployeeMVC.Factory.AbstractFactory
{
    public  interface IComputerFactory
    {

        IProcessors Processor();
        IBrand Brand();
        ISystemType SystemType();
    }
}
