using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using static EmployeeMVC.Factory.AbstractFactory.Enumerations;

namespace EmployeeMVC.Factory.AbstractFactory
{
    public class Dell : IBrand
    {
        public string GetBrand()
        {
            return Brands.Dell.ToString();
        }
    }
}