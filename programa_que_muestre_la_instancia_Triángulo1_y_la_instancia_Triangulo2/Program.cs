using System;

namespace programa_que_muestre_la_instancia_Triángulo1_y_la_instancia_Triangulo2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            triangulo triangulo1;
            triangulo1 = new triangulo();
            Console.WriteLine(triangulo1.calculararea());
            triangulo triangulo2 = new triangulo();
            Console.WriteLine(triangulo2.calculararea());
        }
    }

    class triangulo
    {
        int Base = 20;
        int Altura = 30;

        public int calculararea()
        {
            return Base * Altura /2;
        }
    }
}
