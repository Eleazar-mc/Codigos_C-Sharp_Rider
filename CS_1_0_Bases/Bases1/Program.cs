using System;

namespace Bases1
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Hola mundo C#");
            
            int i = 123;
            Object o = i; // Boxing
            int j = (int) o; // Unboxing
            Console.WriteLine(j);
            
            const float pi = 3.1415927f;
            const int r = 25;
            Console.WriteLine(pi * r * r);
            
            const int x = int.MaxValue;
            unchecked 
            {
                Console.WriteLine(x + 1);  // Overflow
            }
            // checked 
            // {
            //     Console.WriteLine(x + 1);  // Exception
            // }
        }
    }
}