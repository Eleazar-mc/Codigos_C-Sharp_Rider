using System;

namespace Tipos3
{
    class Fabrica
    {
        internal static int Contador;
        internal readonly int Numero;

        public Fabrica()
        {
            this.Numero = Contador++;
        }
    }

    class Program
    {
        static void Main()
        {
            for (int i = 1; i < 10; i++)
            {
                Fabrica f = new Fabrica();
                Console.WriteLine(f.Numero + " , " + Fabrica.Contador);
            }
        }
    }
}