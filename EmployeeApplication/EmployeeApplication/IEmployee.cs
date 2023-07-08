namespace EmployeeInterface
{
    public interface IEmployee
    {
        string FirstName { get; set; }
        string LastName { get; set; } 
        string Department { get; set; }
        string JobTitle { get; set; }
        double RatePerHour { get; set; }
        double TotalHoursWorked { get; set; }

        double CalculateSalary();
    }
}
