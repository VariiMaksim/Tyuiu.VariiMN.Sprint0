﻿using Tyuiu.VariiMN.Sprint0.Task6.V0.Lib;

namespace Tyuiu.VariiMN.Sprint0.Task6.V0
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arraynums = new int[] { 1, 2, 3, 4, 5 };
            Console.WriteLine("Сумма элементов массива = " + DataService.AdditionArray(arraynums));
            Console.WriteLine("Разность элемента массива = " + DataService.SubtractionArray(arraynums));
            Console.WriteLine("Произведение элемента массива = " + DataService.MultiplicationArray(arraynums));

            Console.ReadKey();
        }
    }
}