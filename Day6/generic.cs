class Genericseg
{
    void print(int number)
    {
        Console.WriteLine(number);
    }

    void print1(string namee)
    {
        Console.WriteLine(namee);
    }
}

public class Genericseg<T>
{
    void print(T value)
    {
        Console.WriteLine(value);
    }
}