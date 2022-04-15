using System;
using MatrixArith_Library;

namespace MatrixArithApp
{
    class Program
    {
        public static double[,] Filling(double[,] array)
        {
            Random random = new Random();
            double[,] newArray = new double[array.GetLength(0), array.GetLength(1)];
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    newArray[i, j] = (random.Next(5));
                }
            }
            return newArray;
        }
        static void Main(string[] args)
        {
            var Arr1 = Filling(new double[5, 3]);
            var Arr2 = Filling(new double[3, 5]);
            var Arr3 = Filling(new double[3, 3]);
            Operations calculate = new Operations();
            Console.WriteLine("╔═══════════════════╗");
            Console.WriteLine("       Матрицы");
            Console.WriteLine("╚═══════════════════╝");
            while (true)
            {
                Console.WriteLine("Введите вид операции:");
                Console.WriteLine("1 - Операции c несколькими массивами");
                Console.WriteLine("2 - Операции с одним массивом");
                Console.Write("Действие: ");
                int count = int.Parse(Console.ReadLine());
                switch (count)
                {
                    case 1:
                        calculate.SeveralArraysOper(Arr1, Arr2);
                        break;
                    case 2:
                        calculate.SingleArraysOper(Arr3);
                        break;
                    default:
                        Console.WriteLine("Неверный ввод");
                        break;
                }
            }
        }
    }
}
