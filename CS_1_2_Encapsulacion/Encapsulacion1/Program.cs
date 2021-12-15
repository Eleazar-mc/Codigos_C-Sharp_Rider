using System;

namespace Encapsulacion1
{
    class Punto
    {
        public double X { get; set; }
        public double Y { get; set; }

        public Punto()
        {
            this.X = 0.0;
            this.Y = 0.0;
        }

        public Punto(double x, double y)
        {
            this.X = x;
            this.Y = y;
        }

        public Punto(Punto p)
        {
            this.X = p.X;
            this.Y = p.Y;
        }
        public override string ToString()
        {
            return "(" + this.X + "," + this.Y + ")";
        }
    }

    class Circulo
    {
        public Punto C { get; set; }
        public double R { get; set; }

        public Circulo()
        {
            this.C.X = 0.0;
            this.C.Y = 0.0;
            this.R = 1.0;
        }

        public Circulo(double x, double y, double r)
        {
            this.C.X = x;
            this.C.Y = y;
            this.R = r;
        }

        public Circulo(Punto c, double r)
        {
            this.C = c;
            this.R = r;
        }

        public override string ToString()
        {
            return "(" + this.C.X + "," + this.C.Y + "):" + this.R;
        }
    }
    
    class Program
    {
        static void Main()
        {
            Punto p = new Punto();
            Console.WriteLine(p);
            p.X = 0.005;
            Console.WriteLine(p);
            Circulo c = new Circulo(p, 6.32);
            Console.WriteLine(c);
            c.R = 4.69;
            Console.WriteLine(c);
            Console.WriteLine(c.C);
        }
    }
}