/*using System;
public class Manager : Employee
{
    public string dept;
    public double Bonus;
    public Manager(int i , string e, double s, string d, double b)
: base(i, e, s, d, b)
    {
        dept = d;
        Bonus = b;
    }

    public void DisplayManager()
    {
        Display();
        Console.WriteLine("Dept: " + dept);
        Console.WriteLine("Bonus: " + Bonus);
        Console.WriteLine("------------");
    }
}*/

using System;

public class Manager : Employee
{
    public string Dept { get; set; }
    public double Bonus { get; set; }

    public Manager(int i, string e, double s, string d, double b)
        : base(i, e, s)
    {
        Dept = d;
        Bonus = b;
    }

    public void DisplayManager()
    {
        Display();
        Console.WriteLine("Dept: " + Dept);
        Console.WriteLine("Bonus: " + Bonus);
        Console.WriteLine("----------------");
    }
}