using System;

public class Employee
{
    // Instance fields
    public string Name;
    public int Salary;

    // Static field
    public static int TotalEmployees = 0;

    // Constructor
    public Employee(string name, int salary)
    {
        Name = name;
        Salary = salary;
        TotalEmployees++;
    }

    // Static method
    public static void DisplayTotalEmployees()
    {
        Console.WriteLine($"Total employees: {TotalEmployees}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Employee emp1 = new Employee("Alice", 50000);
        Employee emp2 = new Employee("Bob", 60000);

        Console.WriteLine($"{emp1.Name} earns {emp1.Salary}"); // Alice earns 50000
        Console.WriteLine($"{emp2.Name} earns {emp2.Salary}"); // Bob earns 60000

        Employee.DisplayTotalEmployees(); // Total employees: 2
    }
}