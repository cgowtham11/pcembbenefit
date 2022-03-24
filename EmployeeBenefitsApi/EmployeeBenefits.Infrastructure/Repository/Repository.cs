using System.Collections.Generic;
using EmployeeBenefits.Domain;
using System.Threading.Tasks;

namespace EmployeeBenefits.Infrastructure
{
    public interface IRepository
    {
        Task<List<Employee>> GetEmployees();
    }
    public class Repository : IRepository
    {
        public async Task<List<Employee>> GetEmployees()
        {
            List<Employee> employees = new List<Employee>()
            {
                new Employee("Aaron", new List<Dependent>()
                {
                    new Dependent("Wisly", Dependent.DependentType.Spouse),
                    new Dependent("Kate", Dependent.DependentType.Child),
                    new Dependent("Smith", Dependent.DependentType.Child)
                }, 52000),
                new Employee("John", new List<Dependent>()
                {
                    new Dependent("Cory", Dependent.DependentType.Spouse),
                    new Dependent("Wind", Dependent.DependentType.Child),
                    new Dependent("Kat", Dependent.DependentType.Child)
                }, 70000),
                new Employee("Smith", new List<Dependent>()
                {
                    new Dependent("Kile", Dependent.DependentType.Spouse),
                    new Dependent("Nandy", Dependent.DependentType.Child),
                    new Dependent("Rome", Dependent.DependentType.Child)
                }, 40000),
                 new Employee("Randy", new List<Dependent>()
                {
                    new Dependent("Kelly", Dependent.DependentType.Spouse),
                    new Dependent("Sunny", Dependent.DependentType.Child),
                    new Dependent("Andy", Dependent.DependentType.Child)
                }, 80000)
            };
            return await Task.FromResult(employees);
        }
    }
}
