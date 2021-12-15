using System;

namespace Construccion1
{
    internal class Bowl {
        public Bowl(int marker) {
            Console.WriteLine("Bowl(" + marker + ")");
        }
        public void F1(int marker) {
            Console.WriteLine("f1(" + marker + ")");
        }
    }
    internal class Table {
        static Table()
        {
            _bowl1 = new Bowl(1);
            _bowl2 = new Bowl(2);
        }
        private static Bowl _bowl1;
        public Table() {
            Console.WriteLine("Table()");
            _bowl2.F1(1);
        }
        public void F2(int marker) {
            Console.WriteLine("f2(" + marker + ")");
        }
        static Bowl _bowl2;
    }
    internal class Cupboard {
        Bowl _bowl3 = new Bowl(3);
        static Bowl _bowl4;
        public Cupboard() {
            Console.WriteLine("Cupboard()");
            _bowl4.F1(2);
        }
        public void F3(int marker) {
            Console.WriteLine("f3(" + marker + ")");
        }
        static Bowl _bowl5;

        static Cupboard()
        {
            _bowl4 = new Bowl(4);
            _bowl5 = new Bowl(5);
        }
    }
    public class StaticInitialization {
        public static void Main() {
            Console.WriteLine("Creating new Cupboard() in main");
            new Cupboard();
            Console.WriteLine("Creating new Cupboard() in main");
            new Cupboard();
            _table.F2(1);
            _cupboard.F3(1);
        }

        static StaticInitialization() {
            _table = new Table();
            _cupboard = new Cupboard();
        }

        private static Table _table;
        private static Cupboard _cupboard;
    }
}