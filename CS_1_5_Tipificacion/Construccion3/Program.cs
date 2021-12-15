using System;

namespace Construccion3
{
    internal class Mug {
        public Mug(int marker) {
            Console.WriteLine("Mug(" + marker + ")");
        }
        public void F(int marker) {
            Console.WriteLine("f(" + marker + ")");
        }
    }
    public class Mugs {
        Mug mug1;
        Mug mug2;
        Mugs() {
            mug1 = new Mug(1); // C# no soporta bloques de inicialización de instancia
            mug2 = new Mug(2);
            Console.WriteLine("mug1 & mug2 initialized");
            Console.WriteLine("Mugs()");
        }
        Mugs(int i) {
            mug1 = new Mug(1);
            mug2 = new Mug(2);
            Console.WriteLine("mug1 & mug2 initialized");
            Console.WriteLine("Mugs(int) " + i);
        }
        public static void Main() {
            Console.WriteLine("Inside main()");
            new Mugs();
            Console.WriteLine("new Mugs() completed");
            new Mugs(1);
            Console.WriteLine("new Mugs(1) completed");
        }
    }
}