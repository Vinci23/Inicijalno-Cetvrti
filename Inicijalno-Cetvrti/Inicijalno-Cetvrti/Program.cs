using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inicijalno_Cetvrti
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 3;
            int y = 0;
            int z = 5;

            if (x>0 && y>0 && z>0)
            {
                if ((z*z) == (x*x) + (y*y))
                {
                    Console.WriteLine("Trokut je pravokutan.");
                }
                else
                {
                    Console.WriteLine("Trokut nije pravokutan.");
                }
            }  
            
            else
            {
                Console.WriteLine("Stranice ne mogu biti 0, niti manje od 0!");
            }

            Console.ReadKey();
        }
    }
}
