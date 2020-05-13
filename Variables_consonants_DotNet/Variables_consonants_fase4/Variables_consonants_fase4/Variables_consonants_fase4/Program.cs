using System;

namespace Variables_consonants_fase4
{
    class Program
    {
        static void Main(string[] args)
        {
            string nom = "Marc", cognom1 = "Lladó", cognom2 = "Maldonado";
            int dia = 9, mes = 1, any = 1995;

            string nomcomplet = nom + " " + cognom1 + " " + cognom2;
            string naixement = dia.ToString() + "/" + mes.ToString() + "/" + any.ToString();
            // convertim dia,mes i any a string pero poder-lo guardar tot junt en format XX/XX/XXXXX

            Console.WriteLine("El meu nom és " + nomcomplet);
            Console.WriteLine("Vaig néixer el " + naixement);

            if (any % 4 == 0)
                Console.WriteLine("El meu any de naixement és de traspàs");

            else
                Console.WriteLine("El meu any de naixement NO és de traspàs");
        }
    }
}
