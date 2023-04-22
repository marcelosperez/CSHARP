using System;
using System.Globalization;

namespace MyApp
{
    class Program
    {
        static void Main(string[] args)
        {

            Triangulo x, y;
            x = new Triangulo();
            y = new Triangulo();

            double lado1x, lado2x, lado3x, lado1y, lado2y, lado3y;

            int invalidoX = 0;
            int invalidoY = 0;

            Console.Write("Lado1 do Triangulo X : ");
            lado1x = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.SetA(lado1x);
            Console.Write("Lado2 do Triangulo X : ");
            lado2x = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.SetB(lado2x);
            Console.Write("Lado3 do Triangulo X : ");
            lado3x = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.SetC(lado3x);

            Console.WriteLine(" "); // blank line

            if (lado1x > lado2x + lado3x || lado2x > lado1x + lado3x || lado3x > lado1x + lado2x)
            {
                Console.WriteLine("Valores do Triangulo X invalidos !");
                Console.WriteLine("Um lado não pode ser maior que a soma dos outros dois ");
                Console.WriteLine(" "); // blank line
                invalidoX = 1;
            }

            Console.Write("Lado1 do Triangulo Y : ");
            lado1y = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.SetA(lado1y);
            Console.Write("Lado2 do Triangulo Y : ");
            lado2y = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.SetB(lado2y);
            Console.Write("Lado3 do Triangulo Y : ");
            lado3y = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.SetC(lado3y);

            Console.WriteLine(" "); // blank line

            if (lado1y > lado2y + lado3y || lado2y > lado1y + lado3y || lado3y > lado1y + lado2y)
            {
                Console.WriteLine("Valores do Triangulo Y invalidos !");
                Console.WriteLine("Um lado não pode ser maior que a soma dos outros dois ");
                Console.WriteLine(" "); // blank line
                invalidoY = 1;
            }


            double areaX = x.Area();
            double areaY = y.Area();

            double perX = x.Perimetro();
            double perY = y.Perimetro();


            if (invalidoX == 0)
            {
                Console.WriteLine("Perimetro de X = " + perX.ToString("F4", CultureInfo.InvariantCulture));
                Console.WriteLine("Área de X = " + areaX.ToString("F4", CultureInfo.InvariantCulture));
                Console.WriteLine(" "); // blank line
            }


            if (invalidoY == 0)
            {
                Console.WriteLine("Perimetro de Y = " + perY.ToString("F4", CultureInfo.InvariantCulture));
                Console.WriteLine("Área de Y = " + areaY.ToString("F4", CultureInfo.InvariantCulture));
                Console.WriteLine(" "); // blank line
            }

            if (invalidoX == 0 && invalidoY == 0)
            {
                if (areaX > areaY)
                {
                    Console.WriteLine("X tem a maior area ");
                    Console.WriteLine(" "); // blank line
                }
                else
                {
                    Console.WriteLine("Y tem a maior area ");
                    Console.WriteLine(" "); // blank line
                }
            }



        }
    }
}