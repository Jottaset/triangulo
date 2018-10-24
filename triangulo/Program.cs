using System;

namespace triangulo
{
    class Program
    {
        static void Main(string[] args)
        {
            int ladoA;             int ladoB;             int ladoC;              string texto;              Console.WriteLine("Digite um Valor para o lado A");             ladoA = Int32.Parse(Console.ReadLine());             texto = "\nladoA: " + ladoA;             Console.WriteLine("Valor da variavel texto: " + texto);              Console.WriteLine("Digite um Valor para o lado B");             ladoB = Int32.Parse(Console.ReadLine());             texto += "\nladoB: " + ladoB;             Console.WriteLine("Valor da variavel texto: " + texto);              Console.WriteLine("Digite um Valor para o lado C");             ladoC = Int32.Parse(Console.ReadLine());             texto += "\nladoC: " + ladoC;              Console.WriteLine(texto);
        }
    }
}
