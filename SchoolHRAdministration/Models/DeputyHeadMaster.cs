using HRAdministrationAPI;

namespace SchoolHRAdministration.Models
{
    public class DeputyHeadMaster : EmployeeBase
    {
        public override decimal Salary { get => base.Salary + base.Salary * 0.04m; }
    }
}