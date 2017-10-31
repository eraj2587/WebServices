using System;
using System.ServiceModel.Security;
using Client.EmployeeService;

namespace Client
{
    class WCFClient
    {
        private EmployeeService.WCFServiceClient service;

        public WCFClient()
        {
            service=new WCFServiceClient();
            //add authentication
            service.ClientCredentials.UserName.UserName = "Raj";
            service.ClientCredentials.UserName.Password = "Shelar";
            service.ClientCredentials.ServiceCertificate.Authentication.CertificateValidationMode = X509CertificateValidationMode.None;
        }

        public void CallService()
        {
            
            Console.Title = "WCF Service";
            Console.WriteLine("\nEnter any letter to find name or esc to exit");
            var key = Console.ReadKey();

            if(key.Key==ConsoleKey.Escape) 
                Environment.Exit(0);

            Console.ForegroundColor = ConsoleColor.White;
            var employees = service.GetEmployeeByName(key.KeyChar.ToString());
            Console.WriteLine("\nEmployee details are as below");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\nID\tName\tAddress\tSalary\n");
            Console.ForegroundColor = ConsoleColor.Magenta;
            foreach (var emp in employees)
                Console.WriteLine("{0}\t{1}\t{2}\t{3}", emp.Id, emp.Name, emp.Address, emp.Salary);

        }

    }
}
