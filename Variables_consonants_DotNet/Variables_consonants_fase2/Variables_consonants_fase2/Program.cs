using System;

namespace Variables_consonants_fase2
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 1948, z = 4, anys_traspas;     // 1948 es un any de traspàs
            anys_traspas = (1995 - x) / z;
            Console.WriteLine("Nº Anys de traspàs des de 1948 fins 1995: " + anys_traspas);
        }
    }
}
