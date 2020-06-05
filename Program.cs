using System;

namespace Polimorfismo_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculo infoPlayer = new Calculo();

            // opçao sem argumentos
            Console.WriteLine(infoPlayer.CalcularVida());

            // opçao com 1 argumento int
            Console.WriteLine(infoPlayer.CalcularVida(100));

            // opçao com 2 argumentos int
            Console.WriteLine(infoPlayer.CalcularVida(100, 40));

            // opçao com 2 argumentos string
            Console.WriteLine(infoPlayer.Calcular("Peter", "Parker"));
        }
    }
}
