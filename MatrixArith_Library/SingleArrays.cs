using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrixArith_Library
{
    class SingleArrays : Operands
    {
        public double N { get; set; }
        public int Rang { get; private set; }
        public SingleArrays(double[,] FirstArray)
        {
            this.FirstArray = FirstArray;
            X1 = FirstArray.GetLength(0);
            Y1 = FirstArray.GetLength(1);
            Array_result = new double[X1, Y1];
            counter1 = Math.Abs(X1 - Y1);
        }
        static int MinValue(int first_value, int second_value)
        {
            if (first_value <= second_value) return first_value;
            else return second_value;
        }
        public override double[,] Multiplication()
        {
            for (int i = 0; i < Y1; i++)
            {
                for (int j = 0; j < X1; j++)
                {
                    Array_result[i, j] = FirstArray[i, j] * N;
                }
            }
            return Array_result;
        }
        public void Rank()
        {
            if (X1 == Y1)
            {
                int rang = 0;
                int count = 1;
                while (count <= MinValue(FirstArray.GetLength(0), FirstArray.GetLength(1)))
                {
                    double[,] matrix = new double[count, count];
                    for (int i = 0; i < (FirstArray.GetLength(0) - (count - 1)); i++)
                    {
                        for (int j = 0; j < (FirstArray.GetLength(1) - (count - 1)); j++)
                        {
                            for (int k = 0; k < count; k++)
                            {
                                for (int c = 0; c < count; c++)
                                {
                                    matrix[k, c] = FirstArray[i + k, j + c];
                                }
                            }
                            if (matrix != null)
                                rang = count;
                        }
                    }
                    count++;
                }
                this.Rang = rang;
            }
        }

        public double[,] Square(int stepen=1)
        {
            double[,] SecondArray = FirstArray;
            int count = 1;
            while (count < stepen)
            {
                Array_result = new double[X1,Y1];
                for (int i = 0; i < X1; i++)
                {
                    for (int j = 0; j < Y1; j++)
                    {
                        for (int c = 0; c < Y1; c++)
                        {
                            Array_result[i, j] += FirstArray[i, c] * SecondArray[c, j];
                        }
                    }
                }
                SecondArray = Array_result;
                count++;
            }
            return Array_result;
        }
        public double[,] Transpon()
        {
            double[,] t_array = new double[Y1, X1];
            for (int i = 0; i < X1; i++)
            {
                for (int j = 0; j < Y1; j++)
                {
                    t_array[j, i] = FirstArray[i, j];
                }
            }
            return t_array;
        }
        public void oneMat()
        {
            int count = 0;
            for (int i = 0; i < X1; i++)
            {
                for (int j = 0; j < Y1; j++)
                {
                    if (FirstArray[i, j] == 1 && i == j)
                    {
                        count++;
                    }
                }

            }
            if(count == X1)
                Console.WriteLine("Матрица - единичная");
            else
                Console.WriteLine("Матрица - не единичная");
        }
    }
}
