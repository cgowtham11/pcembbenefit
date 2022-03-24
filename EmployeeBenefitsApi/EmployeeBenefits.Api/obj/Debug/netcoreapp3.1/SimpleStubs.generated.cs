using  System;
using  System.Runtime.CompilerServices;
using  Etg.SimpleStubs;
using EmployeeBenefits.Domain;
using EmployeeBenefits.Domain.Model;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using EmployeeBenefits.Application.Queries;
using System.Linq;

namespace EmployeeBenefits.Application.Queries
{
    [CompilerGenerated]
    public class StubIEmployeeBenefitService : IEmployeeBenefitService
    {
        private readonly StubContainer<StubIEmployeeBenefitService> _stubs = new StubContainer<StubIEmployeeBenefitService>();

        public MockBehavior MockBehavior { get; set; }

        global::System.Threading.Tasks.Task<global::EmployeeBenefits.Domain.Model.BenifitSummary> global::EmployeeBenefits.Application.Queries.IEmployeeBenefitService.ExecuteAsync(global::EmployeeBenefits.Domain.Employee employee)
        {
            ExecuteAsync_Employee_Delegate del;
            if (MockBehavior == MockBehavior.Strict)
            {
                del = _stubs.GetMethodStub<ExecuteAsync_Employee_Delegate>("ExecuteAsync");
            }
            else
            {
                if (!_stubs.TryGetMethodStub<ExecuteAsync_Employee_Delegate>("ExecuteAsync", out del))
                {
                    return System.Threading.Tasks.Task.FromResult(default(global::EmployeeBenefits.Domain.Model.BenifitSummary));
                }
            }

            return del.Invoke(employee);
        }

        public delegate global::System.Threading.Tasks.Task<global::EmployeeBenefits.Domain.Model.BenifitSummary> ExecuteAsync_Employee_Delegate(global::EmployeeBenefits.Domain.Employee employee);

        public StubIEmployeeBenefitService ExecuteAsync(ExecuteAsync_Employee_Delegate del, int count = Times.Forever, bool overwrite = false)
        {
            _stubs.SetMethodStub(del, count, overwrite);
            return this;
        }

        public StubIEmployeeBenefitService(MockBehavior mockBehavior = MockBehavior.Loose)
        {
            MockBehavior = mockBehavior;
        }
    }
}

namespace EmployeeBenefits.Application
{
    [CompilerGenerated]
    public class StubIEmployeeQuery : IEmployeeQuery
    {
        private readonly StubContainer<StubIEmployeeQuery> _stubs = new StubContainer<StubIEmployeeQuery>();

        public MockBehavior MockBehavior { get; set; }

        global::System.Threading.Tasks.Task<global::System.Collections.Generic.List<global::EmployeeBenefits.Domain.Employee>> global::EmployeeBenefits.Application.IEmployeeQuery.ExecuteAsync()
        {
            ExecuteAsync_Delegate del;
            if (MockBehavior == MockBehavior.Strict)
            {
                del = _stubs.GetMethodStub<ExecuteAsync_Delegate>("ExecuteAsync");
            }
            else
            {
                if (!_stubs.TryGetMethodStub<ExecuteAsync_Delegate>("ExecuteAsync", out del))
                {
                    return System.Threading.Tasks.Task.FromResult(default(global::System.Collections.Generic.List<global::EmployeeBenefits.Domain.Employee>));
                }
            }

            return del.Invoke();
        }

        public delegate global::System.Threading.Tasks.Task<global::System.Collections.Generic.List<global::EmployeeBenefits.Domain.Employee>> ExecuteAsync_Delegate();

        public StubIEmployeeQuery ExecuteAsync(ExecuteAsync_Delegate del, int count = Times.Forever, bool overwrite = false)
        {
            _stubs.SetMethodStub(del, count, overwrite);
            return this;
        }

        public StubIEmployeeQuery(MockBehavior mockBehavior = MockBehavior.Loose)
        {
            MockBehavior = mockBehavior;
        }
    }
}

namespace EmployeeBenefits.Application.Service
{
    [CompilerGenerated]
    public class StubIBenefitCalculator : IBenefitCalculator
    {
        private readonly StubContainer<StubIBenefitCalculator> _stubs = new StubContainer<StubIBenefitCalculator>();

        public MockBehavior MockBehavior { get; set; }

        decimal global::EmployeeBenefits.Application.Service.IBenefitCalculator.GetBenefitRate(bool isDependent)
        {
            GetBenefitRate_Boolean_Delegate del;
            if (MockBehavior == MockBehavior.Strict)
            {
                del = _stubs.GetMethodStub<GetBenefitRate_Boolean_Delegate>("GetBenefitRate");
            }
            else
            {
                if (!_stubs.TryGetMethodStub<GetBenefitRate_Boolean_Delegate>("GetBenefitRate", out del))
                {
                    return default(decimal);
                }
            }

            return del.Invoke(isDependent);
        }

        public delegate decimal GetBenefitRate_Boolean_Delegate(bool isDependent);

        public StubIBenefitCalculator GetBenefitRate(GetBenefitRate_Boolean_Delegate del, int count = Times.Forever, bool overwrite = false)
        {
            _stubs.SetMethodStub(del, count, overwrite);
            return this;
        }

        public StubIBenefitCalculator(MockBehavior mockBehavior = MockBehavior.Loose)
        {
            MockBehavior = mockBehavior;
        }
    }
}

namespace EmployeeBenefits.Application.Service
{
    [CompilerGenerated]
    public class StubIBenefitDiscountContext : IBenefitDiscountContext
    {
        private readonly StubContainer<StubIBenefitDiscountContext> _stubs = new StubContainer<StubIBenefitDiscountContext>();

        public MockBehavior MockBehavior { get; set; }

        global::EmployeeBenefits.Application.Service.IBenefitCalculator global::EmployeeBenefits.Application.Service.IBenefitDiscountContext.GetBenefitContext(string name)
        {
            GetBenefitContext_String_Delegate del;
            if (MockBehavior == MockBehavior.Strict)
            {
                del = _stubs.GetMethodStub<GetBenefitContext_String_Delegate>("GetBenefitContext");
            }
            else
            {
                if (!_stubs.TryGetMethodStub<GetBenefitContext_String_Delegate>("GetBenefitContext", out del))
                {
                    return default(global::EmployeeBenefits.Application.Service.IBenefitCalculator);
                }
            }

            return del.Invoke(name);
        }

        public delegate global::EmployeeBenefits.Application.Service.IBenefitCalculator GetBenefitContext_String_Delegate(string name);

        public StubIBenefitDiscountContext GetBenefitContext(GetBenefitContext_String_Delegate del, int count = Times.Forever, bool overwrite = false)
        {
            _stubs.SetMethodStub(del, count, overwrite);
            return this;
        }

        public StubIBenefitDiscountContext(MockBehavior mockBehavior = MockBehavior.Loose)
        {
            MockBehavior = mockBehavior;
        }
    }
}