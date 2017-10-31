using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters;
using System.Threading;
using System.Web;
using System.Web.Services;
using System.Web.Services.Protocols;
using System.Xml;
using Domain;

namespace WebServices
{
    /// <summary>
    /// Summary description for CalculatorService
    /// </summary>
    [WebService]
    public class CalculatorService : WebService
    {
        public UserDetail User;

        [WebMethod]
        public string HelloWorld()
        {
            return "Hello World";
        }

        [SoapHeader("User", Required = true)]
        [WebMethod(CacheDuration = 30,Description = "Filter employees by their name")]
        public List<Employee> GetEmployeeByName(string name)
        {
            if(User == null || !User.IsValid()) throw new SoapException("Invalid credentials",XmlQualifiedName.Empty);
            Employee e = new Employee();
            return e.GetEmployeeByName(name);
        } 

    }

    public class UserDetail : SoapHeader
    {
        public string userName { get; set; }
        public string password { get; set; }


        public bool IsValid()
        {
            //Write the logic to Check the User Details From DataBase  
            //i can chek with some hardcode details UserName=Nitin and Password=Pandit  
            return this.userName == "Raj" && this.password == "Shelar";
            //it'll check the details and will return true or false   
        }
    }

}
