using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeBenefits.Domain.Helper
{
    public class EmployeeValidation
    {
        private const string NameValidationFailureMessage = "Name is mandatory";
        private const string PayValidationFailureMessage = "Annaual Pay is mandatory";
        private const string DepndentSpouseValidationFailureMessage = "One Spouse is allowed";
        public static bool ValidateEmployee(string name, decimal annualPay, List<Dependent> dependents, out string validationError)
        {
            return ValidateName(name, out validationError) ? ValidatePay(annualPay, out validationError) ?
                ValidateDependentSpouse(dependents, out validationError) : false : false;
        }
        public static bool ValidateName(string name, out string message)
        {
            message = string.Empty;
            if (string.IsNullOrWhiteSpace(name))
            {
                message = NameValidationFailureMessage;
                return false;
            }
            return true;
        }
        private static bool ValidatePay(decimal pay, out string message)
        {
            message = string.Empty;
            if (pay <= 0)
            {
                message = PayValidationFailureMessage;
                return false;
            }
            return true;
        }
        private static bool ValidateDependentSpouse(List<Dependent> dependents, out string message)
        {
            message = string.Empty;
            if (dependents?.FindAll(x => x.Type == Dependent.DependentType.Spouse)?.Count > 1)
            {
                message = DepndentSpouseValidationFailureMessage;
                return false;
            }
            return true;
        }
    }
}
