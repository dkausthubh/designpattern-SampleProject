using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using static EmployeeMVC.Factory.AbstractFactory.Enumerations;

namespace EmployeeMVC.Factory.AbstractFactory
{
    public class EmployeeSystemManager
    {
        IComputerFactory _IComputerFactory;
        public EmployeeSystemManager(IComputerFactory icomputerFactory)
        {
            _IComputerFactory = icomputerFactory;
        }
        public string GetSystemDetails()
        {
            IBrand brand = _IComputerFactory.Brand();
            IProcessors processor = _IComputerFactory.Processor();
            ISystemType systemType = _IComputerFactory.SystemType();

            string returnValue = string.Format("{0} {1} {2}", brand.GetBrand(),
            systemType.GetSystemType(), processor.GetProcessors());
            return returnValue;

        }
    }
}