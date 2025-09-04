namespace CSharpFundamentals.Core.Models.User
{
    public class Developer : Employee
    {
        public string ProgrammingLanguage { get; set; }


        public Developer(int employeeId, string name, decimal salary, string programmingLanguage)
        {
            EmployeeId = employeeId;
            Name = name;
            Salary = salary;
            ProgrammingLanguage = programmingLanguage;
        }

        public Developer() { }
    }


}
