using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrixArith_Library
{
    abstract class Operands
    {
        protected internal double[,] FirstArray { get; protected set; }
        protected internal double[,] Array_result { get; protected set; }
        protected int counter1 { get; set; }
        public int X1 { get; protected set; }
        public int Y1 { get; protected set; }
        public abstract double[,] Multiplication();
        public void ShowArray(double[,] array)
        {
            Console.WriteLine("-------");
            Console.WriteLine("Матрица");
            Console.WriteLine("-------");
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    string prob = "  ";
                    if (array[i, j] < 10) { prob = "   "; }
                    Console.Write(array[i, j].ToString()+ prob);
                }
                Console.WriteLine("\n");
            }
        }
    }
}

