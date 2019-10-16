using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApp1.Manager;
using WebApp1.Models;

namespace WebApp1.Factory.FactoryMethod
{
    //add another layer of abstraction when having same implementation and specific implementation
    public class PermanentEmployeeFactory : BaseEmployeeFactory
    {
        public PermanentEmployeeFactory(Employee emp) : base(emp)
        {
        }

        // specific implementation
        public override IEmployeeManager Create()
        {
            PermanentEmployeeManager manager = new PermanentEmployeeManager();
            _emp.HouseAllowance = manager.GetHouseAllowance();
            return manager;
        }
    }
}