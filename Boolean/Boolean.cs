using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio
{
    class Program
    {

        static bool Is4digits(string pin)
        {
            if (pin.Length != 4)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        static void Main(string[] args)
        {
            Console.Write("Digite um numero de 4 digitos: ");
            string PIN = Console.ReadLine();
            if (Is4digits(PIN) == true)
            {
                Console.WriteLine("Pin valido!");
            }
            else
            {
                Console.WriteLine("Pin recusado!");
            }
            Console.ReadLine();
        }
    }
}
