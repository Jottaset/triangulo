using System;

namespace triangulo
{
    class Program
    {
        static void Main(string[] args)
        {

             Triangulo triangulo = new Triangulo();

            Console.WriteLine("Informe o valor do lado A: ");
            //triangulo.ladoA = Int32.Parse(Console.ReadLine());
            triangulo.defineValorLadoA(Int32.Parse(Console.ReadLine()));

            //Console.WriteLine("Informe o valor do lado B: ");
            //triangulo.ladoB = Int32.Parse(Console.ReadLine());

            //Console.WriteLine("Informe o valor do lado C: ");
            //triangulo.ladoC = Int32.Parse(Console.ReadLine());

            Console.WriteLine("LadoA: " + triangulo.pegaValorLadoA() + "\n");
            //Console.WriteLine("LadoB: " + triangulo.ladoB + "\n");
            //Console.WriteLine("LadoC: " + triangulo.ladoC + "\n");
        }
    }
}
