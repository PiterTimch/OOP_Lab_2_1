using System;
using System.Collections.Generic;
using System.Linq;

namespace Lab_2_1
{
    public class Program
    {
        static double CalculateTask1_11(double x) 
        {
            return Math.Sqrt(Math.Log(Math.Pow(x, 2) - 4));
        }

        static void TestTask1_11()
        {
            double[] testValues = { 3, 4, 5, 6, 10 };
            foreach (var x in testValues)
            {
                try
                {
                    double result = CalculateTask1_11(x);
                    Console.WriteLine($"x: {x}, Result: {result}");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"x: {x}, Error: {ex.Message}");
                }
            }
        }

        static int[] Task2_11(int n)
        {
            var random = new Random();
            int[][] matrix = new int[n][];

            for (int i = 0; i < n; i++)
            {
                matrix[i] = new int[n];
                for (int j = 0; j < n; j++)
                {
                    matrix[i][j] = random.Next(-100, 100);
                    Console.Write(matrix[i][j] + "\t");
                }
                Console.WriteLine();
            }

            int[] result = new int[n];

            for (int i = 0; i < n; i++)
            {
                int numOfIterations = -1;
                for (int j = n-1; j >= 0; j--)
                {
                    if (matrix[i][j] < 0)
                    {
                        numOfIterations = j;
                        break;
                    }
                }

                if (numOfIterations == -1)
                {
                    result[i] = -1;
                    continue;
                }

                int rowSum = 0;
                for (int j = 0; j < numOfIterations; j++)
                {
                    rowSum += matrix[i][j];
                }
                result[i] = rowSum;
            }

            return result;
        }

        static void TestTask2_11()
        {
            int[] testValues = { 3, 4, 5, 6, 10 };
            foreach (var n in testValues)
            {
                try
                {
                    int[] result = Task2_11(n);
                    Console.WriteLine($"n: {n}, Result: [{string.Join(", ", result)}]");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"n: {n}, Error: {ex.Message}");
                }
            }
        }

        static void TestFraction()
        {
            Fraction frac1 = new Fraction(3, 4);
            Fraction frac2 = new Fraction(5, 6);
            Console.WriteLine($"Fraction 1: {frac1}");
            Console.WriteLine($"Fraction 2: {frac2}");
            frac1.Add(frac2);
            Console.WriteLine($"After Addition: {frac1}");
            Fraction frac3 = frac1.Multiply(frac2);
            Console.WriteLine($"After Multiplication: {frac3}");
        }

        static void Main(string[] args)
        {
            TestTask1_11();
            TestTask2_11();
            TestFraction();
        }
    }
}
