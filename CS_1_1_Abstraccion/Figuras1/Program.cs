using System;

namespace Figuras1
{
    internal abstract class Figura // internal hace que la clase se accesible solo en el ensamblaje
    {
        private readonly string _color;

        protected Figura(string color)
        {
            this._color = color;
        }

        public abstract double Area();

        protected string GetColor()
        {
            return _color;
        }
    }

    internal class Circulo : Figura
    {
        private readonly double _radio;

        public Circulo(string color, double radio): base(color)
        {
            this._radio = radio;
        }

        public override double Area()
        {
            return Math.PI * Math.Pow(this._radio, 2);
        }

        public override string ToString()
        {
            return "Área del círculo: " + this.Area() + " con color " + this.GetColor();
        }
    }

    internal class Rectangulo : Figura
    {
        private readonly double _largo;
        private readonly double _ancho;

        public Rectangulo(string color, double largo, double ancho) : base(color)
        {
            this._largo = largo;
            this._ancho = ancho;
        }

        public override double Area()
        {
            return this._largo * this._ancho;
        }

        public override string ToString()
        {
            return "Área del triángulo: " + Area() + " de color " + GetColor();
        }
    }
    
    class Program
    {
        static void Main()
        {
            Circulo f1 = new Circulo("Verde", 2.2);
            Rectangulo f2 = new Rectangulo("Rojo", 2, 4);
            Console.WriteLine(f1);
            Console.WriteLine(f2);
        }
    }
}