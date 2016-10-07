using EmployeeTracker.Services.Charts;
using System.Collections.Generic;

namespace EmployeeTracker.Services.Dashboards
{
    public class Dashboard : IDashboard
    {
        public int TotalPositions { get; set; }
        public int TotalOffices { get; set; }
        public int TotalEmployees { get; set; }
        public IEnumerable<ChartData> EmployeesPerYear { get; set; }
        public IEnumerable<ChartData> EmployeesPerOffice { get; set; }
    }
}
