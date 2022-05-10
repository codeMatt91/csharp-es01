
using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Chiedo all'utente due numeri

            Console.WriteLine("inserisci il primo numero:");
            string n1 = Console.ReadLine();
            Console.WriteLine("Inserisci il secondo numero:");
            string n2 = Console.ReadLine();

            // Parso i numeri
            int iN1 = Int32.Parse(n1);
            int iN2 = Int32.Parse(n2);


            Console.WriteLine("Hai inserito: {0}, {1}", iN1, iN2);

            // Faccio la moltiplicazione dei numeri 
            Console.WriteLine("La loro moltiplicazione: {0}", Multi(iN1, iN2));
        }

        static int Multi(int n1, int n2)
        { 
            return n1 * n2;
        }

    }
}
