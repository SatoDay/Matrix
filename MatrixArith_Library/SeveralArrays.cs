using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrixArith_Library
{
    class SeveralArrays : Operands
    {
        protected internal double[,] SecondArray { get; protected set; }
        public SeveralArrays(double[,] array1 = null, double[,] array2 = null)
        {
            if(array1 is double[,]) 
            {
                FirstArray = array1;
                SecondArray = array2;
                X1 = FirstArray.GetLength(0);
                Y1 = SecondArray.GetLength(1);
                Array_result = new double[Y1, X1];
                counter1 = Math.Abs(FirstArray.GetLength(0) - FirstArray.GetLength(1));
            }
            else
                Console.WriteLine("Введите массивы!!!"); 
        }
        public bool Identical()//проверка на то, чтобы размеры матриц были одинаковы
        {
            if (FirstArray.GetLength(0) == SecondArray.GetLength(0) & FirstArray.GetLength(1) == SecondArray.GetLength(1))
                return true;
            else
                return false;
        }
        public double[,] Addition()
        {
            for (int i = 0; i < Y1; i++)
            {
                for (int j = 0; j < X1; j++)
                {
                    Array_result[i, j] = FirstArray[i, j] + SecondArray[i, j];
                }
            }
            return Array_result;
        }
        public double[,] Subtraction()
        {
            for (int i = 0; i < Y1; i++)
            {
                for (int j = 0; j < X1; j++)
                {
                    Array_result[i, j] = FirstArray[i, j] - SecondArray[i, j];
                }
            }
            return Array_result;
        }
        public override double[,] Multiplication()
        {
            for (int i = 0; i < X1; i++)
            {
                for (int j = 0; j < Y1; j++)
                {
                    for (int c = 0; c < Y1-counter1; c++)
                    {
                        Array_result[i, j] += FirstArray[i, c] * SecondArray[c, j];
                    }
                }
            }
            return Array_result;
        }
    }
}
