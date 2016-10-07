using Autofac;
using EmployeeTracker.Services.Common;
using EmployeeTracker.Services.Dashboards;
using EmployeeTracker.Services.Employees;
using EmployeeTracker.Services.SqlServer;

namespace EmployeeTracker.Api
{
    public class AutofacModule : Module
    {
        private string _connectionString;

        public AutofacModule(string connectionString)
        {
            _connectionString = connectionString;
        }

        protected override void Load(ContainerBuilder builder)
        {
            // Register Connection class and expose IConnection 
            // by passing in the Database connection information
            builder.RegisterType<Connection>() // concrete type
                .As<IConnection>() // abstraction
                .WithParameter("connectionString", _connectionString)
                .InstancePerLifetimeScope();

            // Register Repository class and expose IRepository
            builder.RegisterType<Repository>()
                .As<IRepository>()
                .InstancePerLifetimeScope();

            // Register DashboardService class and expose IDashboardService
            builder.RegisterType<DashboardService>()
                .As<IDashboardService>()
                .InstancePerLifetimeScope();

            // Register EmployeeService class and expose IEmployeeService
            builder.RegisterType<EmployeeService>()
                .As<IEmployeeService>()
                .InstancePerLifetimeScope();
        }
    }
}
