using System;
using System.Globalization;

namespace MyApp
{
    class Program
    {
        static void Main(string[] args)
        {

            Triangulo x;
            x = new Triangulo();
  
            double lado1x;

            Console.Write("Lado1 do Triangulo X : ");
            lado1x = double.Parse(Console.ReadLine());
            x.SetA(lado1x);
           
            Console.WriteLine("Valor digitado é: " + x.GetA());




        }
    }
}