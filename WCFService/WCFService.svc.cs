using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using Domain;

namespace WCFService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class WCFService : IWCFService
    {
        public List<Employee> GetEmployeeByName(string name)
        {
            try
            {
                Employee e = new Employee();
                return e.GetEmployeeByName(name);
            }
            catch (Exception ex)
            {
                throw new FaultException<GenericFaultContract>(new GenericFaultContract {error = ex.Message,stack = ex.StackTrace});
            } 
        }
    }
}
