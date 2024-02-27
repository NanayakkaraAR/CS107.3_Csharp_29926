using System;
namespace que_2;

internal class Program
{
    static void Main(string[] args)
    {
        Employee employee = new Employee(101, "JOhn Doe, 50000.00");

        Console.WriteLine("Employee Information");
        employee.DisplayEmployeeInfo();

        Console.WriteLine($"Employee ID{employee.EmployeeID}");


        employee.FullName = "Jane Smith";
        Console.WriteLine($"Updateed full name {employee.FullName}");
        employee.Salary = 55000;
        Console.WriteLine($"updated salary{employee.salary}");

        Console.ReadLine();

    }
}

internal class Employee
{
    public int employeeID;
    public string fullName;
    public double salary;
    public Employee(int employeeID, string FullName, double salary)

    {
        this.employeeID = employeeID;
        this.fullName = FullName;
        this.salary = salary;
    }

    public int EmployeedID => employeeID;
    public string FullName

    {
        get => FullName;
        set => FullName = value;
    }

public double Salary

    {
        get => salary;
        set => salary = value;
    }

public void DisplayEmployeeInfo()

    {
        Console.WriteLine($"Employee ID {employeeID}");
        Console.WriteLine($"Full Name {employeeID}");
        Console.WriteLine($"Salary {employeeID}");
    }   
}

