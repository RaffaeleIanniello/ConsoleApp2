using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Inserisci il nome del prodotto:");
            string nome = Console.ReadLine();

            Console.WriteLine("Inserisci il prezzo del prodotto:");
            double prezzo = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Inserisci la quantità del prodotto:");
            double quantità = Convert.ToDouble(Console.ReadLine());

           

            Console.ReadLine();
        }
    }
}
