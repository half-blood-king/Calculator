using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            int[][,] a=new int[3][,];
            a[0] = new int[2,2]{ {1,2},{3,4}};
            a[1] = new int[2, 1]{{2},{23}};
            a[2] = new int[3, 2] { { 12, 34 }, { 23, 55 }, { 3, 5 } };

     
            for (i = 0; i < 3; i++)
            {
                Console.WriteLine();
                Console.Write("Array index#{0} :", i+"\t");
                for (int j = 0; j < a[i].GetLength(0); j++)
                {
         
                    for (int k = 0; k < a[i].GetLength(1); k++)
                    {

                        Console.Write("[{0}][{1}]=>{2}",j,k,a[i][j, k] + "\t");
                        
                    }
                   
                }
                Console.WriteLine();
            }

                        Console.Read();
        }
    }
}
