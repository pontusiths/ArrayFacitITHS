﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayFacit
{
    class Program
    {
        public const int hej = 0;
        static void Main(string[] args)
        {
            //ExerciseOne();
            //ExerciseTwo();
            //ExerciseThree();
            //ExerciseFour();
            //ExerciseFive();
            //ExerciseSix();
            //ExerciseSevenA();
            //ExerciseSevenB();
            //ExerciseSevenC();
            //ExerciseSevenD();
            //ExerciseSevenE();
            //ExerciseSevenF();
            //ExerciseSevenG();
            //ExerciseSevenH();
            //ExerciseSevenI();
            //ExerciseSevenJ();
            //ExerciseSevenK();
            //ExerciseEight();
            //ExerciseNine();
            //ExerciseTen();
            ExerciseEleven();
        }

        private static void ExerciseEleven()
        {
            char[,] mapArray = new char[,]
            {
                {'#', '#', '#', '#', '#' },
                {'#', '-', '-', '-', '#' },
                {'#', '-', '-', '-', '#' },
                {'#', '-', '@', '-', '#' },
                {'#', '-', '-', '-', '#' },
                {'#', '-', '-', '-', '#' },
                {'#', '#', '#', '#', '#' }
            };

            while (true)
            {
                for (int row = 0; row < mapArray.GetLength(0); row++)
                {
                    for (int column = 0; column < mapArray.GetLength(1); column++)
                    {
                        Console.Write(mapArray[row, column]);
                    }
                    Console.WriteLine();
                }
                char move = Console.ReadKey().KeyChar;
                switch (move)
                {
                    case 'w':
                        ExerciseElevenMovement(mapArray, -1, 0);
                        break;

                    case 'a':
                        ExerciseElevenMovement(mapArray, 0, -1);
                        break;

                    case 's':
                        ExerciseElevenMovement(mapArray, 1, 0);
                        break;

                    case 'd':
                        ExerciseElevenMovement(mapArray, 0, 1);
                        break;

                    default:
                        break;
                }
                Console.Clear();
            }
        }

        private static void ExerciseElevenMovement(char[,] mapArray, int y, int x)
        {
            int rowIndex = 0;
            int columnIndex = 0;
            for (int i = 0; i < mapArray.GetLength(0); i++)
            {
                for (int j = 0; j < mapArray.GetLength(1); j++)
                {
                    if (mapArray[i, j].Equals('@'))
                    {
                        rowIndex = i;
                        columnIndex = j;
                        break;
                    }
                }
            }
            mapArray[rowIndex, columnIndex] = '-';
            mapArray[rowIndex + y, columnIndex + x] = '@';
        }

        public static void ExerciseTen()
        {
            char[,] myArray = new char[,]
            {
                { '#', '-', '-', '-', '#', '-', '-', '-' },
                { '-', '#', '-', '-', '-', '#', '-', '-' },
                { '-', '-', '#', '-', '-', '-', '#', '-' },
                { '-', '-', '-', '#', '-', '-', '-', '#' }
            };

            for (int row = 0; row < myArray.GetLength(0); row++)
            {
                for (int column = 0; column < myArray.GetLength(1); column++)
                {
                    Console.Write(myArray[row, column]);
                }
                Console.WriteLine();
            }
            Console.ReadKey(true);
        }

        public static void ExerciseNine()
        {
            int[,] array2D = new int[,] { { 1, 2 }, { 3, 4 }, { 5, 6 }, { 7, 8 } }; //Värdet variablen får är en multidimensionell array
                                                                                    //{alltså är värdet siffrorna inom måsvingarna}
        }

        private static void ExerciseEight()
        {
            var random = new Random();
            int[] numbers = new int[5];
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = random.Next(1, 20);
            }

            bool needSorting = true;
            for (int i = 0; i < numbers.Length - 1 && needSorting == true; i++)
            {
                needSorting = false;
                for (int j = 0; j < numbers.Length - 1 - i; j++)
                {
                    if (numbers[j] > numbers[j + 1])
                    {
                        int temp = numbers[j];
                        numbers[j] = numbers[j + 1];
                        numbers[j + 1] = temp;

                        needSorting = true;
                    }
                }
            }

            for (int i = 0; i < numbers.Length; i++) //Demonstration
            {
                Console.WriteLine(numbers[i]);
            }
            Console.ReadKey();
        }

        private static void ExerciseSevenK()
        {
            for (int y = 1; y < 5; y++)
            {
                for (int x = 1; x < 9; x++)
                {
                    if ((y == 1 || y == 2) && (x % 2 != 0)) Console.Write("##");

                    else if (y == 3 && (x < 4)) Console.Write("ww");

                    else if (y == 3 && (x > 3)) Console.Write("~~");

                    else if (y == 4) Console.Write("##");

                    else Console.Write("--");
                }
                Console.WriteLine("");
            }
            Console.ReadKey(true);
        }

        private static void ExerciseSevenJ()
        {
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (i == 4 / 2 && j == 4 / 2)
                    {
                        Console.Write("O");
                    }
                    else if (i == j)
                    {
                        Console.Write("#");
                    }
                    else if (i + j == 4)
                    {
                        Console.Write("#");
                    }
                    else 
                    {
                        Console.Write("-");
                    }
                }
                Console.WriteLine();
            }
            Console.ReadKey(true);
        }

        private static void ExerciseSevenI()
        {
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    if (j == 2 && i != 1)
                    {
                        Console.Write("#");
                    }
                    else
                    {
                        Console.Write("-");
                    }
                }
                Console.WriteLine();
            }
            Console.ReadKey(true);
        }

        private static void ExerciseSevenH()
        {
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    if (i + 1 == j)
                    {
                        Console.Write("#");
                    }
                    else if (j > 3 && i < 2)
                    {
                        Console.Write("#");
                    }
                    else
                    {
                        Console.Write("-");
                    }
                }
                Console.WriteLine();
            }
            Console.ReadKey(true);
        }

        private static void ExerciseSevenG()
        {
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    if (i < 3 && j < 3)
                    {
                        Console.Write("#");
                    }
                    else
                    {
                        Console.Write("-");
                    }
                }
                Console.WriteLine();
            }
            Console.ReadKey(true);
        }

        private static void ExerciseSevenF()
        {
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if ((i + j) % 2 == 0)
                    {
                        Console.Write("#");
                    }
                    else
                    {
                        Console.Write("-");
                    }
                }
                Console.WriteLine();
            }
            Console.ReadKey(true);
        }

        private static void ExerciseSevenE()
        {
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    if (i == j)
                    {
                        Console.Write("#");
                    }
                    else if (i + j == 4)
                    {
                        Console.Write("#");
                    }
                    else
                    {
                        Console.Write("-");
                    }
                }
                Console.WriteLine();
            }
            Console.ReadKey(true);
        }

        private static void ExerciseSevenD()
        {
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    if (j == 2 || j == 5)
                    {
                        Console.Write("#");
                    }
                    else if (i == 2)
                    {
                        Console.Write("#");
                    }
                    else
                    {
                        Console.Write("-");
                    }
                }
                Console.WriteLine();
            }
            Console.ReadKey(true);
        }

        private static void ExerciseSevenC()
        {
            for (int y = 0; y < 4; y++)
            {
                for (int x = 0; x < 4; x++)
                {
                    if ((y == x)) Console.Write("##");

                    else Console.Write("--");
                }
                Console.WriteLine("");
            }
            Console.ReadKey();
        }

        private static void ExerciseSevenB()
        {
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    if (i == j)
                    {
                        Console.Write("#");
                    }
                    else if (i + 4 == j)
                    {
                        Console.Write("#");
                    }
                    else
                    {
                        Console.Write("-");
                    }
                }
                Console.WriteLine();
            }
            Console.ReadKey(true);
        }

        private static void ExerciseSevenA()
        {
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    if (i == j)
                    {
                        Console.Write("#");
                    }
                    else
                    {
                        Console.Write("-");
                    }
                }
                Console.WriteLine();
            }
            Console.ReadKey(true);
        }

        private static void ExerciseSix()
        {
            //Det skriver ut ett 5 x 5 rutnät med en diagonal linje av karaktären # ifrån övrevänster hörne till nedre högre hörne  
        }

        private static void ExerciseFive()
        {
            var random = new Random();
            Console.WriteLine("Give me a number");
            int length;
            if (int.TryParse(Console.ReadLine(), out length) == false)
            {
                ExerciseFive();
                return;
            }
            int[] numbers = new int[length];
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = random.Next(1,100);
            }
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
            }
            double average = (double)numbers.Sum() / (double)numbers.Length;
            Console.WriteLine("average:" + Math.Round(average, 2));
        }

        private static void ExerciseFour()
        {
            string[] colors = new string[] { "gul", "grön", "orange", "blå", "grå" };
            for (int i = 0; i < colors.Length; i++)
            {
                Console.WriteLine(colors[i]);
            }
        }

        private static void ExerciseThree()
        {
            var random = new Random();
            int[] numbers = new int[5];
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = random.Next(1, 20);
            }
            int oddNumbers = 0;
            int maxNumber = 0;
            int minNumber = 20;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 != 0)
                {
                    oddNumbers++;
                }
                if (numbers[i] > maxNumber)
                {
                    maxNumber = numbers[i];
                }
                if (numbers[i] < minNumber)
                {
                    minNumber = numbers[i];
                }
            }

            //alternativt sätt att ta ut min eller max(Kräver using System.Linq; i dina imports längst upp i filen):
            minNumber = numbers.Min();
            maxNumber = numbers.Max();
            Console.WriteLine($"There are {oddNumbers} odd numbers.");
            Console.WriteLine($"{maxNumber} is the maximum value");
            Console.WriteLine($"{minNumber} is the minimum value");
        }

        private static void ExerciseTwo()
        {
            int[] numbers = new int[] { 2, 3, 5, 8, 13, 21, 34};
            Console.WriteLine(numbers.Sum());
            //Extra
            int sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (i % 2 == 0)
                {
                    sum += numbers[i];
                }
                else
                {
                    sum -= numbers[i];
                }
            }
            Console.WriteLine(sum);
            Console.ReadKey(true);
        }

        private static void ExerciseOne()
        {
            string[] colors = new string[] { "gul","grön","orange","blå","grå" };
            Console.WriteLine(colors[0]);
            Console.WriteLine(colors[1]);
            Console.WriteLine(colors[2]);
            Console.WriteLine(colors[3]);
            Console.WriteLine(colors[4]);
        }
    }
}
