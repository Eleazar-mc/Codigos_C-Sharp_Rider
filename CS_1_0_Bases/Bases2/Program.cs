using System;

namespace Bases2
{
    internal class Program
    {
        private Program()
        {
            Console.WriteLine("Constructor");
        }

        private string _nombre = "Ulises"; // Valor default: null
        private static int _control = 49; // Valor default 0

        private void Saludar()
        {
            Console.WriteLine("Hola método de instancia");
            Console.WriteLine(_nombre);
        }

        private static void Mc()
        {
            Console.WriteLine("Método de clase: " + _control);
        }

        private static void Main()
        {
            new Program().Saludar();
            Mc();
        }

        static Program()
        {
            Console.WriteLine("Carga de clase");
        }

        // C# no soporta los inicializadores de instancia como en Java
    }
}