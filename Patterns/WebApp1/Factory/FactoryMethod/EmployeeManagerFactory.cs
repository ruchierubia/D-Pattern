using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApp1.Models;

namespace WebApp1.Factory.FactoryMethod
{
    public class EmployeeManagerFactory
    {
        public BaseEmployeeFactory CreateFactory(Employee emp)
        {
            BaseEmployeeFactory retVal = null;
            if (emp.EmployeeTypeID == 1)
                retVal = new PermanentEmployeeFactory(emp);
            else if (emp.EmployeeTypeID == 2)
                retVal = new ContactEmployeeFactory(emp);
            return retVal;

        }
    }
}