using System;

namespace Bases3
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine(new Program());
            Console.WriteLine(new Program().GetType());
            Console.WriteLine(new Program().ToString());
            Console.WriteLine(new Program().GetHashCode());
        }
    }
}