using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_Es01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int v1, v2;
            Console.Write("inserisci un numero:");
            if (!int.TryParse(Console.ReadLine(), out v1))
            {
                Console.WriteLine("Errore, non è stato digitato un numero");
            }
            Console.Write("inserisci un numero:");
            if (!int.TryParse(Console.ReadLine(), out v2))
            {
                Console.WriteLine("Errore, non è stato digitato un numero");
            }

            System.Console.WriteLine("hello world: {0}, {1}",
                Moltiplica(v1, v2), "ciao");
        }
        static int Moltiplica(int v1, int v2)
        {
            return v1 * v2;
        }
    }


}
