using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Client.CalculatorService;

namespace Client
{
    class WebServiceClient
    {
        private CalculatorServiceSoapClient  service;
      

        public WebServiceClient()
        {
            service = new CalculatorServiceSoapClient();
        }   

        public List<Employee> GetEmployeesByName(string name)
        {
            UserDetail details = new UserDetail {userName = "Raj123", password = "Shelar"};
            return service.GetEmployeeByName(details, name).ToList();
        }

        public void CallService()
        {
            Console.Title = "Web Service";
            Console.WriteLine("\nEnter any letter to find name");
            var key = Console.ReadKey();

          
            var employees = GetEmployeesByName(key.KeyChar.ToString());

            Console.WriteLine("\nEmployee details are as below");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\nID\tName\tAddress\tSalary\n");
            Console.ForegroundColor = ConsoleColor.Magenta;
            foreach (var emp in employees)
                Console.WriteLine("{0}\t{1}\t{2}\t{3}", emp.Id, emp.Name, emp.Address, emp.Salary);
        }

    }

  

}
