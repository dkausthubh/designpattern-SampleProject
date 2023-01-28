using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using static EmployeeMVC.Factory.AbstractFactory.Enumerations;

namespace EmployeeMVC.Factory.AbstractFactory
{
    public class I3 : IProcessors
    {
        public string GetProcessors()
        {
            return Processors.I3.ToString();
        }
    }
    public class I5 : IProcessors
    {
        public string GetProcessors()
        {
            return Processors.I5.ToString();
        }
    }
    public class I7 : IProcessors
    {
        public string GetProcessors()
        {
            return Processors.I7.ToString();
        }
    }
}