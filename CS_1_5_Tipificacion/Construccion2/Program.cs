using System;

namespace Construccion2
{
    internal class Cup {
        public Cup(int marker) {
            Console.WriteLine("Cup(" + marker + ")");
        }
        public void F(int marker) {
            Console.WriteLine("f(" + marker + ")");
        }
    }
    internal class Cups {
        internal static readonly Cup _cup1;
        private static Cup _cup2;
        static Cups() {
            _cup1 = new Cup(1);
            _cup2 = new Cup(2);
        }
        public Cups() {
            Console.WriteLine("Cups()");
        }
    }
    public class ExplicitStatic {
        public static void Main() {
            Console.WriteLine("Inside main()");
            Cups._cup1.F(99); // (1)
        }
        // static ExplicitStatic()
        // {
        //     cups1 = new Cups(); // (2)
        //     cups2 = new Cups(); // (2)
        // }
        // private static Cups cups1;
        // private static Cups cups2;
    }
}