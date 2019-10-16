using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApp1.Manager;

namespace WebApp1.Factory
{
    public class EmployeeManagerFactory
    {
        public IEmployeeManager GetEmployeeManager(int empTypId)
        {
            IEmployeeManager retVal = null;

            if (empTypId == 1)
                retVal = new PermanentEmployeeManager();
            else if (empTypId == 2)
                retVal = new ContractEmployeeManager();
            return retVal;
        }
    }
}