using System;

namespace Polimorfismo6
{
    class Grain
    {
        public override string ToString()
        {
            return "Grain";
        }
    }

    class Wheat : Grain
    {
        public override string ToString()
        {
            return "Wheat";
        }
    }

    class Mill
    {
        public virtual Grain Process()
        {
            return new Grain();
        }

        public Object Process2()
        {
            return 7.7;
        }
    }

    class WheatMill : Mill
    {
        public override Grain Process() // No se soportan los tipos covariantes
        {
            return new Wheat(); // EL polimorfismo ayuda a tratar con los subtipos
        }

        public string Process2()
        {
            return "X";
        }
    }
    
    class Program
    {
        static void Main()
        {
            Mill m = new Mill();
            Grain g = m.Process();
            Console.WriteLine(g);
            m = new WheatMill();
            g = m.Process();
            Console.WriteLine(g);
        }
    }
}