using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeBenefits.Domain.Exception
{
    public class InValidEmployeeException : System.Exception
    {
        public InValidEmployeeException(string message)
            : base(message)
        {
        }
    }
}
