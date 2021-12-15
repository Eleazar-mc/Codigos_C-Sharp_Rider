using System;

namespace Tipos4
{
    class Rectangulo
    {
        private double Largo;
        private double Ancho;

        public Rectangulo(double largo, double ancho)
        {
            this.Largo = largo;
            this.Ancho = ancho;
        }

        public double Area()
        {
            return this.Largo * this.Ancho;
        }

        public double Perimetro()
        {
            return this.Largo * 2 + this.Ancho * 2;
        }
    }

    class Cuadrado : Rectangulo
    {
        public Cuadrado(double largo) : base(largo, largo)
        {}
    }

    class Program
    {
        public static void Main()
        {
            Cuadrado c = new Cuadrado(4);
            Console.WriteLine("Área del cuadrado: " + c.Area());
            Console.WriteLine("Perímetro del cuadrado: " + c.Perimetro());
            
            Rectangulo r = new Rectangulo(2, 4);
            Console.WriteLine("Área del rectángulo: " + r.Area());
            Console.WriteLine("Perímetro del rectángulo: " + r.Perimetro());
        }
    }
}