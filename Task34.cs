/*Задача 34: Задайте массив заполненный случайными положительными
 трёхзначными числами. Напишите программу, которая покажет 
 количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2*/


using System;

namespace EvenNumberCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[4];
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write("Введите число:");  
                array[i] = int.Parse(Console.ReadLine());
            }
            int evenNumberCounter = 0;

            foreach (int number in array) 
            { 
                if (number % 2 == 0) 
                { 
                    evenNumberCounter++; 
                } 
            }

            Console.WriteLine($"Количество четных чисел в массиве: {evenNumberCounter}");

            Console.ReadKey();

        }
    }
}
