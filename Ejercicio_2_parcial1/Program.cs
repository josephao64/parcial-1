﻿//busca los errores y corrige
using System;

class Program
{
    static void Main(string[] args)
    {
        int num1, num2, sum;

        Console.Write("Ingrese el primer número: ");
        num1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Ingrese el segundo número: ");
        num2 = Convert.ToInt32(Console.ReadLine());

        sum = num1 + num2;

        Console.WriteLine("La suma de {0} y {1} es: {2}", num1, num2, sum);
    }
}
