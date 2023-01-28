using EmployeeMVC.Managers;
using EmployeeMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EmployeeMVC.Factory.FactoryMethod
{
    public class ContractEmployeeFactory : BaseEmployeeFactory

    {
        public ContractEmployeeFactory(Employee emp) : base(emp)
        {
        }

        public override IEmployeeManager Create()
        {

           ContractEmployeeManager manager = new ContractEmployeeManager();
            _emp.Medical_Allowance = manager.GetMedicalAllowance();
            return manager;
        }
    }
}