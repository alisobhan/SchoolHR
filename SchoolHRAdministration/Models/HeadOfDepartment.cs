﻿using HRAdministrationAPI;

namespace SchoolHRAdministration.Models
{
    public class HeadOfDepartment : EmployeeBase
    {
        public override decimal Salary { get => base.Salary + base.Salary * 0.03m; }
    }
}