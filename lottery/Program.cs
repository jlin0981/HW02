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
            
            
            
            int r1 = New.Next(1, 43);
            int r2 = New.Next(1, 43);
            int r3 = New.Next(1, 43);
            int r4 = New.Next(1, 43);
            int r5 = New.Next(1, 43);
            int r6 = New.Next(1, 43);




            Console.WriteLine("{0:00} {1:00} {2:00} {3:00} {4:00} {5:00} ", r1 , r2 , r3 , r4, r5, r6);
            Console.ReadLine();
        }
    }
}
