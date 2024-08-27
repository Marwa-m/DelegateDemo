// Create a list of employees
            List<Employee> employees = new List<Employee>
            {
                new Employee { Id = 1, Name = "Alice Johnson", Salary = 60000, Position = "Developer" },
                new Employee { Id = 2, Name = "Bob Smith", Salary = 75000, Position = "Developer" },
                new Employee { Id = 3, Name = "Charlie Brown", Salary = 90000, Position = "Team Lead" },
                new Employee { Id = 4, Name = "Diana Prince", Salary = 50000, Position = "Tester" },
                new Employee { Id = 5, Name = "Evan Wright", Salary = 120000, Position = "Manager" }
            };

            // Create an instance of the Employee class
            Employee employeeManager = new Employee();

            // Example 1: Print employees with a salary greater than 70,000
            Console.WriteLine("Employees with a salary greater than $70,000:");
            employeeManager.PrintEmployeesMeetingCriteria(employees, e => e.Salary > 70000);
            Console.WriteLine();

            // Example 2: Print bonuses for each employee (10% of their salary)
            Console.WriteLine("Bonuses for each employee:");
            employeeManager.PrintEmployeeBonuses(employees, e => e.Salary * 0.10);
            Console.WriteLine();

            // Example 3: Promote employees with a salary greater than 75,000
            Console.WriteLine("Promoting employees with a salary greater than $75,000:");
            employeeManager.PromoteEmployees(employees, e => e.Salary > 75000);
            Console.WriteLine();