using System;
using System.IO;

public class FileHandling
{
    File.WriteAllText("emp.txt", "Name : abc");

    string data = File.ReadAllText("emp.txt");
    Console.WriteLine(data);
}