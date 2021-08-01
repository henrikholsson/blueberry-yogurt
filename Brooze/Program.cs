using System;

namespace Brooze
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Check out this awsome Service!");

            SomeService service = new SomeService();

            Console.WriteLine($"{nameof(service.GiveMeOne)}-{service.GiveMeOne()}");
            Console.WriteLine($"{nameof(service.GiveMeZero)}-{service.GiveMeZero()}");
        }
    }
}
