namespace CSharpFundamentals.Core.Models.User
{
    public class Manager : Employee
    {
        public string Department { get; set; }

        public Manager(int employeeId, string name, decimal salary, string department)
        {
            EmployeeId = employeeId;
            Name = name;
            Salary = salary;
            Department = department;
        }

        public Manager() { }
    }
}
