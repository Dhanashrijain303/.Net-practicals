/*using System;
class Employee
{
    public int Id{get;set;}
    public string EmpName{get;set;}
    public double MonthlySalary{get;set;}

    Employee(int i,string e, double s)
    {
        Id =i;
        EmpName=e;
        MonthlySalary=s;
    }

    double calculateAnnualSalary()
    {
        return MonthylAnnualSalary*12;
    }

    void Display()
    {
        Console.WriteLine("Id: "+Id);
        Console.WriteLine("Name: "+EmpName);
        Console.WriteLine("Monthly: "+MonthlySalary);
        Console.WriteLine("Annual: "+calculateAnnualSala);
    }
}*/

using System;

public class Employee
{
    public int Id { get; set; }
    public string EmpName { get; set; }
    public double MonthlySalary { get; set; }

    // Constructor
    public Employee(int i, string e, double s)
    {
        Id = i;
        EmpName = e;
        MonthlySalary = s;
    }

    // Method to calculate annual salary
    public double CalculateAnnualSalary()
    {
        return MonthlySalary * 12;
    }

    // Display Method
    public void Display()
    {
        Console.WriteLine("Id: " + Id);
        Console.WriteLine("Name: " + EmpName);
        Console.WriteLine("Monthly Salary: " + MonthlySalary);
        Console.WriteLine("Annual Salary: " + CalculateAnnualSalary());
    }
}