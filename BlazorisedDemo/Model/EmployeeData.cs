namespace BlazorisedDemo.Model
{
    public class EmployeeData
    {
        public Task<List<Employee>> GetDataAsync()
        {
            var employeeList = new List<Employee>
        {
            new Employee { Id = 1, FirstName = "John", LastName = "Doe", Email = "john.doe@example.com", Salary = 60000m },
            new Employee { Id = 2, FirstName = "Jane", LastName = "Smith", Email = "jane.smith@example.com", Salary = 65000m },
            new Employee { Id = 3, FirstName = "Sam", LastName = "Brown", Email = "sam.brown@example.com", Salary = 70000m },
            new Employee { Id = 4, FirstName = "Emily", LastName = "Davis", Email = "emily.davis@example.com", Salary = 75000m }
        };

            return Task.FromResult(employeeList);
        }
    }
}
