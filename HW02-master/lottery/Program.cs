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
            // 設New為隨機變數

            Random New = new Random () ;

            // 是下面的號碼產生為第一組

            int i = 1;

            // 產生1~10組號碼，第十一組不產生

            while ( i < 11)
            {
                // 限制號碼產生範圍介於1~42之間

                int r1 = New.Next(1, 43);
                int r2 = New.Next(1, 43);
                int r3 = New.Next(1, 43);
                int r4 = New.Next(1, 43);
                int r5 = New.Next(1, 43);
                int r6 = New.Next(1, 43);
                int r7 = New.Next(1, 43);

                
                Console.WriteLine("╔═════════════════════════╗");

                // 顯示[第i組] 右邊皆為號碼

                Console.WriteLine("║[{0:00}] {1:00} {2:00} {3:00} {4:00} {5:00} {6:00} {7:00}║", i, r1, r2, r3, r4, r5, r6, r7);
                i += 1;
                Console.WriteLine("╚═════════════════════════╝");
            }
            // 任意鍵結束

            Console.ReadLine();
        }
    }
}
