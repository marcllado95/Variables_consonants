using System;

namespace Variables_consonants_fase3
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 1948;
            
            string bisi = " És de traspàs", norm = " No és de traspàs";
            for (double i = x; i <= 1995; i++)
            {
                bool esbisiesto = false;

                if ((i % 4) == 0)
                    esbisiesto = true;
                            
                Console.Write(i + " ");

                if (esbisiesto)
                    Console.WriteLine(i + bisi);

                else
                    Console.WriteLine(i + norm);     
            }
        }
    }
}
