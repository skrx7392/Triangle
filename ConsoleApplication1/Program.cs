using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int columns = 10;
            for (int i=0; i<columns/2; i++)
            {
                for(int j=0; j<columns; j++)
                {
                    if(j>=columns/2-i && j<=columns/2 + i)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
