using System;
using System.Threading;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Starting myapp...");
        while (true)
        {
            Console.WriteLine("myapp is running...");
            Thread.Sleep(5000);
        }
    }
}
