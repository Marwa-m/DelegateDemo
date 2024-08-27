# Delegate Demo in C#

This project demonstrates the use of delegates in C# for handling various operations on employee data. It showcases how delegates can be used for filtering, calculating bonuses, promoting employees, and notifying multiple departments about promotions using multicast delegates. The project is structured with a main console application and an associated unit test project to ensure the functionality is correct and reliable.

## Project Structure

- **DelegateDemo**: The main console application that includes the `Employee` class and methods for filtering, calculating bonuses, promoting employees, and notifying departments about promotions.
- **DelegateDemo.Tests**: The unit test project using xUnit to test the functionality of the `DelegateDemo` project.

## Features

- **Delegates**: The project showcases how to use delegates for flexible and reusable code:
  - `EmployeeFilter`: Used to filter employees based on custom criteria.
  - `BonusCalculator`: Used to calculate bonuses for employees.
  - `PromotionCriteria`: Used to determine which employees are eligible for promotion.
  - `NotifyPromotion`: A multicast delegate used to notify multiple departments about employee promotions.

- **Multicast Delegates**: The project demonstrates the use of multicast delegates to call multiple methods through a single delegate invocation. This is particularly useful in scenarios where multiple actions need to be taken based on a single event (e.g., notifying HR and a manager about a promotion).

- **Unit Tests**: The project includes unit tests to verify the correctness of each method using the xUnit framework.

## Example Usage

### Filtering Employees
```csharp
employeeManager.PrintEmployeesMeetingCriteria(employees, e => e.Salary > 70000);
```

### Calculating Bonuses Employees
```csharp
employeeManager.PrintEmployeeBonuses(employees, e => e.Salary * 0.10);
```

### Promoting Employees
```csharp
employeeManager.PromoteEmployees(employees, e => e.Salary > 75000);
```

### Multicast Delegate for Notifications
```csharp
NotifyPromotion notify = employeeManager.NotifyDepartments;
notify += employeeManager.NotifyManager;
employeeManager.ExecutePromotionNotifications(employees, notify);
```

## Installation

### Clone the repository:
```bash
git clone https://github.com/Marwa-m/DelegateDemo.git
```

### Build the project:
```bash
dotnet build
```

### Run the project:
```bash
dotnet run
```
### Run the test:
```bash
dotnet test
```
