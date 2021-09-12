using System.Collections.Generic;

namespace BlazorStore.Models
{
    public class EmployeeService : IEmployee
    {
        List<Employee> employees;

        public EmployeeService() {
            employees = new List<Employee> {
                new Employee { Name = "John", Department="IT" },
                new Employee { Name = "Doe", Department="Sales" }

            };
        }
        public List<Employee> GetAllEmployees()
        {
            return employees;
        }
    }
}