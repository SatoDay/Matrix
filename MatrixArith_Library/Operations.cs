using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrixArith_Library
{
    public class Operations
    {
        public void SeveralArraysOper(double[,] FirstArray = null, double[,] SecondArray = null)
        {
            SeveralArrays opera = new SeveralArrays(FirstArray, SecondArray);
            bool condition = true;
            opera.ShowArray(FirstArray);
            Console.WriteLine();
            opera.ShowArray(SecondArray);
            while (condition)
            {
                Console.WriteLine("╔════════════════════════════════════════════════╗");
                Console.WriteLine("   Выберите арифметическую операцию с массивами:");
                Console.WriteLine();
                Console.WriteLine("  1 - Сложение       3 - Умножение");
                Console.WriteLine("  2 - Вычитание      4 - Выход ");
                Console.WriteLine("╚════════════════════════════════════════════════╝");
                Console.Write("Действие: ");
                int command1 = int.Parse(Console.ReadLine());
                switch (command1)
                {
                    case 1:
                        if (opera.Identical())
                            opera.ShowArray(opera.Addition());
                        else { Console.WriteLine("Матрицы должны быть одинаковой размерности!"); }
                        break;
                    case 2:
                        if (opera.Identical())
                            opera.ShowArray(opera.Subtraction());
                        else { Console.WriteLine("Матрицы должны быть одинаковой размерности!"); }
                        break;
                    case 3:
                        if(opera.Identical() | opera.X1==opera.Y1)
                            opera.ShowArray(opera.Multiplication());
                        else { Console.WriteLine("Отношения стоблцов и строк двух матриц должно равняться 1!"); }
                        break;
                    case 4:
                        condition = false;
                        break;
                    default:
                        Console.WriteLine("Неверный ввод");
                        break;
                }
            }
        }
        public void SingleArraysOper(double[,] FirstArray = null)
        {
            SingleArrays singleoper = new SingleArrays(FirstArray);
            bool condition = true;
            singleoper.ShowArray(FirstArray);
            while(condition)
            {
                Console.WriteLine("╔══════════════════════════════════════════════════════╗");
                Console.WriteLine("           Выберите операцию с массивом:");
                Console.WriteLine();
                Console.WriteLine("  1 - Ранг матрицы          4 - Транспонировать матрицу ");
                Console.WriteLine("  2 - Возведение в степень  5 - Проверка на единичность ");
                Console.WriteLine("  3 - Умножение на число    6 - Выход");
                Console.WriteLine("╚══════════════════════════════════════════════════════╝");
                Console.Write("Действие: ");
                int command2 = int.Parse(Console.ReadLine());
                switch (command2)
                {
                    case 1:
                        singleoper.Rank();
                        Console.WriteLine($"Ранг матрицы - {singleoper.Rang}");
                        break;
                    case 2:
                        if (singleoper.X1 == singleoper.Y1)
                        {
                            Console.WriteLine("Введите степень для возведения");
                            singleoper.ShowArray(singleoper.Square(int.Parse(Console.ReadLine())));
                        }
                        else { Console.WriteLine("Матрица должна быть квадратной!"); }
                        break;
                    case 3:
                        Console.Write("Введите число, на которое хотите умножить матрицу => ");
                        singleoper.N = double.Parse(Console.ReadLine());
                        singleoper.ShowArray(singleoper.Multiplication());
                        break;
                    case 4:
                        singleoper.ShowArray(singleoper.Transpon());
                        break;
                    case 5:
                        if (singleoper.X1 == singleoper.Y1)
                            singleoper.oneMat();
                        else { Console.WriteLine("Матрица должна быть квадратной!"); }
                        break;
                    case 6:
                        condition = false;
                        break;
                    default:
                        Console.WriteLine("Неверный ввод");
                        break;
                }
            }
        }
    }
}

