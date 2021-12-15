using System;

namespace Polimorfismo1
{
    interface IAve
    {
        public void Volar();
        public void Nadar();
    }

    class Perico : IAve
    {
        public void Volar()
        {
            Console.WriteLine("Perico volando");
        }

        public void Nadar()
        {
            Console.WriteLine("Un perico no nada");
        }
    }

    class Pinguino : IAve
    {
        public void Volar()
        {
            Console.WriteLine("Un pingüino no vuela");
        }

        public void Nadar()
        {
            Console.WriteLine("Pingüino nadando");
        }
    }
    
    class Program
    {
        public void PruebaVuelo(IAve ave)
        {
            ave.Volar();
        }
        
        static void Main()
        {
            Perico pe = new Perico();
            Pinguino pi = new Pinguino();
            Program p = new Program();
            p.PruebaVuelo(pe);
            p.PruebaVuelo(pi);
        }
    }
}