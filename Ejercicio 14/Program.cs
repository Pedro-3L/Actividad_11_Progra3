using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_14
{
	internal class Program
	{
		static void Main(string[] args)
		{
			double Dividir(double a, double b)
			{
				return a / b;
			}
			Console.WriteLine("Ingrese un numero");
			double num1 = double.Parse(Console.ReadLine());
			Console.WriteLine("Ingrese otro numero");
			double num2 = double.Parse(Console.ReadLine());
			double resultado = Dividir(num1, num2);
			Console.WriteLine("La division es : " + resultado);
		}
	}
}
