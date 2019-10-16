using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApp1.Manager;
using WebApp1.Models;

namespace WebApp1.Factory.FactoryMethod
{
    public abstract class BaseEmployeeFactory
    {
        protected Employee _emp;

        public BaseEmployeeFactory (Employee emp)
        {
            _emp = emp;
        }

        //common implementation
        public Employee ApplySalary()
        {
            IEmployeeManager manager = this.Create();
            _emp.Bonus = manager.GetBonus();
            _emp.HourlyPay = manager.GetPay();

            return _emp;
        }

        //specific
        public abstract IEmployeeManager Create();
    }
}