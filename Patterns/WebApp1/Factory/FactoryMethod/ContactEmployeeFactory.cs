using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApp1.Manager;
using WebApp1.Models;

namespace WebApp1.Factory.FactoryMethod
{
    //add another layer of abstraction when having same implementation and specific implementation
    public class ContactEmployeeFactory : BaseEmployeeFactory
    {
        public ContactEmployeeFactory(Employee emp) : base(emp)
        {
        }

        // specific implementation
        public override IEmployeeManager Create()
        {
            ContractEmployeeManager manager = new ContractEmployeeManager();
            _emp.HouseAllowance = manager.GetMedicalAllowance();
            return manager;
        }
    }
}