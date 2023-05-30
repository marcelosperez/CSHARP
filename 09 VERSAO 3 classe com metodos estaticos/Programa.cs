
using System;
using System.Globalization;

namespace Curso {

     class Program {

					static void Main(string[] args) {

								Console.Write("Entre o valor do raio: ");
								double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

								double circ = Calculadora.Circunferencia(raio);
								double volume = Calculadora.Volume(raio);

								Console.WriteLine("Circunferência: " + circ.ToString("F2", CultureInfo.InvariantCulture));
								Console.WriteLine("Volume: " + volume.ToString("F2", CultureInfo.InvariantCulture));
								Console.WriteLine("Valor de PI: " + Calculadora.PI.ToString("F2", CultureInfo.InvariantCulture));

						} // end static void Main

     } // end class Program

} // end namespace Course














