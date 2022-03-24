using EmployeeBenefits.Domain.Exception;
using EmployeeBenefits.Domain.Helper;
using System;
using System.Collections.Generic;

namespace EmployeeBenefits.Domain
{
    public abstract class Person
    {
        public string Name { get; set; }
    }
    public class Employee : Person
    {
        public Employee() { }
        public decimal AnnualPay { get; set; }
        public List<Dependent> Dependents { get; set; }
        public Employee(string name, List<Dependent> dependents, decimal annualPay)
        {
            if (!EmployeeValidation.ValidateEmployee(name, annualPay, dependents, out string validationMessage))
                throw new InValidEmployeeException(validationMessage);
            Name = name;
            Dependents = dependents;
            AnnualPay = annualPay;
        }
    }
    public class Dependent : Person
    {
        public Dependent() { }
        public Dependent(string name, DependentType type)
        {
            if (!EmployeeValidation.ValidateName(name, out string validationMessage))
                throw new InValidEmployeeException(validationMessage);
            Name = name;
            Type = type;
        }
        public enum DependentType { Spouse, Child }
        public DependentType Type { get; set; }

    }
}
