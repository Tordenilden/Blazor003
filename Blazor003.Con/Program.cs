using Blazor003.repo.Models;
using System;

namespace Blazor003.Con
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Customer c = new Customer();
            int tal = c.getInt();

            Console.WriteLine();

        }
    }
}
