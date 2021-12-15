using System;

namespace Polimorfismo2
{
    class Useful {
        public void F() {
            Console.WriteLine("Useful.f()");
        }
        public void G() {
            Console.WriteLine("Useful.g()");
        }
    }


    class MoreUseful : Useful {
        public new void F() { // Nueva definición local en esta subclase
            Console.WriteLine("MoreUseful.f()");
        }
        public new void G() { // Nueva definición local en esta subclase
            Console.WriteLine("MoreUseful.g()");
        }
        public void U() {
        Console.WriteLine("MoreUseful.u()");
    }
        public void V() {
        Console.WriteLine("MoreUseful.v()");
    }
        public void W() {
        Console.WriteLine("MoreUseful.w()");
    }
    }
    class Program
    {
        static void Main()
        {
            Useful[] x = { new Useful(), new MoreUseful() };
            x[0].F();
            x[1].G(); // Aplica herencia
            ((MoreUseful)x[1]).G(); // Aplica definición local
            ((MoreUseful)x[1]).U(); // Downcasting idéntico a Java
            //((MoreUseful) x[0]).U(); // Error a tiempo de ejecución
        }
    }
}