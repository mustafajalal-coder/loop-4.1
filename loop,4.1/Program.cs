using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace loop_4._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("vilket är världens folkrikaste LAND?");
            string svar = Console.ReadLine();
            while (svar != "kina")
            {
                Console.WriteLine("du svarade fel, försök igen");
                svar = Console.ReadLine();

            }
            Console.WriteLine("grattis! du svarade rätt");
        }
    }
}
