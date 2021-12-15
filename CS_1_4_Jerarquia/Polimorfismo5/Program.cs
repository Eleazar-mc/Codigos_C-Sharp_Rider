using System;

namespace Polimorfismo5
{
    class Volador
    {
        public void Volar()
        {
            Console.WriteLine("Volando");
        }
    }

    interface IExtraterrestre
    {
        void Golpear();
    }

    interface IDebil
    {
        void Debilitar();
    }

    class Superman : Volador, IExtraterrestre, IDebil
    {
        public void Golpear()
        {
            Console.WriteLine("Golpeando");
        }

        public void Debilitar()
        {
            Console.WriteLine("¡La fuerza se reduce!");
        }

        public void Defender()
        {
            Console.WriteLine("Defendiendo el planeta");
        }
    }
    
    class Program
    {
        static void Main()
        {
            Superman s = new Superman();
            s.Volar();
            s.Defender();
            s.Golpear();
            s.Debilitar();
        }
    }
}