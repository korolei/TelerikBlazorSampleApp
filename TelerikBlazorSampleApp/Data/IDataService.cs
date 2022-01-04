using System.Collections.Generic;
using TelerikBlazorSampleApp.Models.Employee;
using TelerikBlazorSampleApp.Models.Sales;

namespace TelerikBlazorSampleApp.Data
{
    public interface IDataService
    {
        List<Employee> GetEmployees();
        IEnumerable<Sale> GetSales();
        List<Team> GetTeams();
    }
}
