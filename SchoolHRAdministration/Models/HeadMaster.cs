﻿using HRAdministrationAPI;

namespace SchoolHRAdministration.Models
{
    public class HeadMaster : EmployeeBase
    {
        public override decimal Salary { get => base.Salary + base.Salary * 0.05m; }
    }
}