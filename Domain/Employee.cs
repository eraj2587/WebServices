using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace Domain
{
    [DataContract]
    public class Employee
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string Name  { get; set; }
        [DataMember]
        public string Address { get; set; }
        [DataMember]
        public int Salary { get; set; }

        public List<Employee> GetEmployees()
        {
            return new List<Employee>
            {
                new Employee()
                {
                    Id=1,Address = "Pune", Name = "Raj",Salary = 10
                },
                new Employee()
                {
                    Id=2,Address = "Mumbai", Name = "Atul",Salary = 20
                },
                new Employee()
                {
                    Id=3,Address = "Bangalore", Name = "Sachin",Salary = 30
                }
            };
        }


        public List<Employee> GetEmployeeByName(string name)
        {
            return GetEmployees().Where(emp => emp.Name.ToLower().StartsWith(name.ToLower())).ToList();
        } 

    }

    public class GenericFaultContract
    {
        public string error { get; set; }
        public string stack { get; set; }
    }

}
