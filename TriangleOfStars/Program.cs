using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriangleOfStars
{
    class Program
    {
        static void Main(string[] args)
        {
            char star = '*';
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write(star);
                }
                Console.WriteLine();
            }           
        }
    }
}
