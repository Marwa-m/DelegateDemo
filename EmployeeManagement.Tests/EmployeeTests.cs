namespace EmployeeManagement.Tests;

public class EmployeeTests
{
    
    [Fact]
        public void PrintEmployeesMeetingCriteria_FiltersEmployeesCorrectly()
        {
            // Arrange
            var employees = GetTestEmployees();
            var employee = new Employee();

            // Act & Assert
            var writer = new StringWriter();
            Console.SetOut(writer);

            employee.PrintEmployeesMeetingCriteria(employees, e => e.Salary > 70000);

            var output = writer.GetStringBuilder().ToString().Trim();
            var expected = "Bob Smith\r\nCharlie Brown\r\nEvan Wright";
            Assert.Equal(expected, output);
        }
        [Fact]
        public void PrintEmployeeBonuses_CalculatesAndPrintsBonusesCorrectly()
        {
            // Arrange
            var employees = GetTestEmployees();
            var employee = new Employee();

            // Act & Assert
            var writer = new StringWriter();
            Console.SetOut(writer);

            employee.PrintEmployeeBonuses(employees, e => e.Salary * 0.10);

            var output = writer.GetStringBuilder().ToString().Trim();
            var expected = 
                "The bonus for Alice Johnson is $6000.00\r\n" +
                "The bonus for Bob Smith is $7500.00\r\n" +
                "The bonus for Charlie Brown is $9000.00\r\n" +
                "The bonus for Diana Prince is $5000.00\r\n" +
                "The bonus for Evan Wright is $12000.00";

            Assert.Equal(expected, output);
        }

        [Fact]
        public void PromoteEmployees_PromotesEligibleEmployeesCorrectly()
        {
            // Arrange
            var employees = GetTestEmployees();
            var employee = new Employee();

            // Act & Assert
            var writer = new StringWriter();
            Console.SetOut(writer);

            employee.PromoteEmployees(employees, e => e.Salary > 75000);

            var output = writer.GetStringBuilder().ToString().Trim();
            var expected = 
                "Charlie Brown has been promoted. New salary: $108000.00\r\n" +
                "Evan Wright has been promoted. New salary: $144000.00";

            Assert.Equal(expected, output);
        }
 private List<Employee> GetTestEmployees()
        {
            return new List<Employee>
            {
                new Employee { Id = 1, Name = "Alice Johnson", Salary = 60000, Position = "Developer" },
                new Employee { Id = 2, Name = "Bob Smith", Salary = 75000, Position = "Developer" },
                new Employee { Id = 3, Name = "Charlie Brown", Salary = 90000, Position = "Team Lead" },
                new Employee { Id = 4, Name = "Diana Prince", Salary = 50000, Position = "Tester" },
                new Employee { Id = 5, Name = "Evan Wright", Salary = 120000, Position = "Manager" }
            };
        }
}