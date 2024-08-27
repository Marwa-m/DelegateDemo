/// <summary>
/// Represents an employee in a company.
/// </summary>
public class Employee
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public double Salary { get; set; }
    public string? Position { get; set; }

    public delegate bool EmployeeFilter(Employee employee);

    /// <summary>
    /// Prints the names of employees that meet the specified filter criteria.
    /// </summary>
    /// <param name="employees">The list of employees.</param>
    /// <param name="filter">The filter criteria as a delegate.</param>
    public void PrintEmployeesMeetingCriteria(List<Employee> employees, EmployeeFilter filter)
    {
        if (employees == null) throw new ArgumentNullException(nameof(employees));

        foreach (var employee in employees)
        {
            if (filter(employee))
            {
                Console.WriteLine($"{employee.Name}");
            }
        }
    }

    public delegate double BonusCalculator(Employee employee);

/// <summary>
/// Prints the bonus for each employee based on the provided bonus calculation logic.
/// </summary>
/// <param name="employees">The list of employees.</param>
/// <param name="bonusCalculator">The delegate that calculates the bonus for each employee.</param>
public void PrintEmployeeBonuses(List<Employee> employees, BonusCalculator bonusCalculator)
{
    if (employees == null) throw new ArgumentNullException(nameof(employees));
    if (bonusCalculator == null) throw new ArgumentNullException(nameof(bonusCalculator));

    foreach (var employee in employees)
    {
        double bonus = bonusCalculator(employee);
        Console.WriteLine($"The bonus for {employee.Name} is ${bonus:F2}");
    }
}

public delegate bool PromotionCriteria(Employee employee);

/// <summary>
/// Promotes employees based on the specified promotion criteria and prints their new salaries.
/// </summary>
/// <param name="employees">The list of employees.</param>
/// <param name="criteria">The delegate that determines whether an employee is eligible for promotion.</param>
public void PromoteEmployees(List<Employee> employees, PromotionCriteria criteria)
{
    if (employees == null) throw new ArgumentNullException(nameof(employees));
    if (criteria == null) throw new ArgumentNullException(nameof(criteria));

    foreach (var employee in employees)
    {
        if (criteria(employee))
        {
            double newSalary = employee.Salary * 1.20;
            Console.WriteLine($"{employee.Name} has been promoted. New salary: ${newSalary:F2}");
        }
    }
}

/// <summary>
/// Delegate for notifying promotions.
/// </summary>
/// <param name="employee">The employee who is being promoted.</param>
public delegate void NotifyPromotion(Employee employee);

/// <summary>
/// Notifies the HR department about an employee's promotion.
/// </summary>
/// <param name="employee">The employee who is being promoted.</param>
public void NotifyDepartments(Employee employee)
{
    Console.WriteLine($"{employee.Name}'s promotion is notified to HR Department.");
}

/// <summary>
/// Notifies the manager about an employee's promotion.
/// </summary>
/// <param name="employee">The employee who is being promoted.</param>
public void NotifyManager(Employee employee)
{
    Console.WriteLine($"{employee.Name}'s promotion is notified to the Manager.");
}

/// <summary>
/// Executes promotion notifications for all employees in the list.
/// </summary>
/// <param name="employees">The list of employees to notify.</param>
/// <param name="notifier">The delegate responsible for notifying the appropriate parties.</param>
public void ExecutePromotionNotifications(List<Employee> employees, NotifyPromotion notifier)
{
    foreach (var employee in employees)
    {
        notifier(employee);
    }
}


}
