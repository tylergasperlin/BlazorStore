using System.Collections.Generic;
using BlazorStore.Models;
using Microsoft.AspNetCore.Components;

namespace BlazorStore.Pages
{
    public partial class EmployeeComponent
    {
        [Inject]
        IEmployee employeeService { get;set; }
        List<Employee> employeeList;
        protected override void OnInitialized()
        {
            base.OnInitialized();
            employeeList = employeeService.GetAllEmployees();
        }
    }
}