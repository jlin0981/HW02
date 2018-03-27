using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lottery
{
    class Program
    {
        static void Main(string[] args)
        {
            Random New = new Random () ;
            int i = 1;

            while ( i < 11)
            {

                int r1 = New.Next(1, 43);
                int r2 = New.Next(1, 43);
                int r3 = New.Next(1, 43);
                int r4 = New.Next(1, 43);
                int r5 = New.Next(1, 43);
                int r6 = New.Next(1, 43);
                int r7 = New.Next(1, 43);


                Console.WriteLine("╔═════════════════════════╗");

                Console.WriteLine("║[{0:00}] {1:00} {2:00} {3:00} {4:00} {5:00} {6:00} {7:00}║", i, r1, r2, r3, r4, r5, r6, r7);
                i += 1;
                Console.WriteLine("╚═════════════════════════╝");
            }
            Console.ReadLine();
        }
    }
}
