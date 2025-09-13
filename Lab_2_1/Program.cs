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

        static List<int> Task2_11(uint n) 
        {
            var random = new Random();
            List<List<int>> matrix = new List<List<int>>();

            for (int i = 0; i < n; i++)
            {
                matrix.Add(new List<int>(Convert.ToInt32(n)));

                for (int j = 0; j < n; j++)
                {
                    matrix[i].Add(random.Next(-100, 100));
                    Console.Write(matrix[i][j] + "\t");
                }
                Console.WriteLine();
            }

            List<int> result = new List<int>();

            for (int i = 0; i < matrix.Count; i++)
            {
                int numOfIterations = matrix[i].FindIndex(x => x < 0) != -1 ? matrix[i].FindIndex(x => x < 0) : matrix[i].Count;

                if (numOfIterations == matrix[i].Count)
                {
                    result.Add(-1);
                    continue;
                }

                int rowSum = 0;

                for (int j = 0; j < numOfIterations; j++)
                {
                    rowSum += matrix[i][j];
                }
                result.Add(rowSum);
            }

            return result;
        }

        static void TestTask2_11()
        {
            uint[] testValues = { 3, 4, 5, 6, 10 };
            foreach (var n in testValues)
            {
                try
                {
                    List<int> result = Task2_11(n);
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
