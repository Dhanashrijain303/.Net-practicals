using System;
class Exceptioneg
{
    static void CheckAge(int age)
    {
        if (age < 20)
        {
            throw new Exception("NOT eligible")
        }
        Console.WriteLine("can attend")
    }
    static void Main()
    {
        try
        {
            int a=50;
            int b=5;
            int c=a/b;
            Console.WriteLine(c);
        } catch(DivideByZeroException e)
        {
            Console.WriteLine(e.Message);
        }

        try
        {
            CheckAge(25);
        }catch(Exception e)
        {
            Console.WriteLine()
        }
        
    }
    
}