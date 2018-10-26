using System;
namespace triangulo
{
    public class Triangulo
    {
        private int ladoA;
        private int ladoB;
        private int ladoC;

        public Triangulo()
        {
        }
        public void defineValorLadoA(int valorDaTelaladoA)
        {
            ladoA = valorDaTelaladoA;
        }

        public string pegaValorLadoA()
        {
            return " Valor: " ladoA.ToString();
        }
    }
}
