using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIsAndJSON
{
    public static class Pause
    {
        public static void Slow()
        {
            for (int i = 0; i < 5; i++)
            {
                Thread.Sleep(1000);
                Console.Write(". ");
            }
            Console.WriteLine();
        }
    }
}
