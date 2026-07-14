/*using System;

delegate void MessageDelegate(string message);

class Delegateeg
{
    static MessageDelegate m;

    static void Display(string message)
    {
        Console.WriteLine("Method1 : " + message);
    }

    static void Display1(string message)
    {
        Console.WriteLine("Method2 : " + message);
    }

    static void Display2(string message)
    {
        Console.WriteLine("Method3 : " + message);
    }

    static void Main()
    {
        m = Display;
        m += Display1;
        m += Display2;

        m("Hello,I am Learning .NET C#");

        Button bt =new Button();
        bt.Click +=() => Console.WriteLine("Click Event");
        bt.Press();
    }
}*/