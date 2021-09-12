using System.Collections.Generic;

namespace BlazorStore.Models
{
    public interface IEmployee
    {
         public List<Employee> GetAllEmployees();
    }
}