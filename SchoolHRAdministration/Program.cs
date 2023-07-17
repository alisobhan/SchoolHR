using HRAdministrationAPI;

namespace SchoolHRAdministration
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal totalSalaries = 0;
            var employees = new List<IEmployee>();

            SeedData(employees);

            foreach (var employee in employees) 
            {
                totalSalaries += employee.Salary;
            }

            Console.WriteLine($"Total Annual Salaries Including Bouns: {totalSalaries}"); ;


        }
        public static void SeedData(List<IEmployee> employees)
        {
            IEmployee teacher1 = new Teacher
            {
                Id = 1,
                FirstName = "James",
                LastName = "Smith",
                Salary = 4000
            };
            employees.Add(teacher1);

            IEmployee headOfDepartment = new HeadOfDepartment
            {
                Id = 2,
                FirstName = "Mohammad",
                LastName = "Ali",
                Salary = 5000
            };
            employees.Add(headOfDepartment);

            IEmployee deputyHeadMaster = new DeputyHeadMaster
            {
                Id = 3,
                FirstName = "Bob",
                LastName = "Ross",
                Salary = 8000
            };
            employees.Add(deputyHeadMaster);

            IEmployee headMaster = new HeadMaster
            {
                Id = 4,
                FirstName = "Hana",
                LastName = "Baker",
                Salary = 10000

            };
            employees.Add(headMaster);
            IEmployee teacher2 = new Teacher
            {
                Id = 4,
                FirstName = "Sara",
                LastName = "Soltan",
                Salary = 4000

            };
            employees.Add(teacher2);
        }
    }

    public class Teacher:EmployeeBase
    {
        public override decimal Salary { get => base.Salary + (base.Salary * 0.2m); }
    }

    public class HeadOfDepartment : EmployeeBase 
    {
        public override decimal Salary { get => base.Salary + (base.Salary * 0.3m); }
    }

    public class DeputyHeadMaster : EmployeeBase 
    {
        public override decimal Salary { get => base.Salary + (base.Salary * 0.4m); }
    }

    public class HeadMaster : EmployeeBase
    {
        public override decimal Salary { get => base.Salary + (base.Salary * 0.5m); }
    }
}