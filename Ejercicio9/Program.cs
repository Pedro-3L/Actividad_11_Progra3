using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio9
{
	internal class Program
	{
		static void Main(string[] args)
		{
			void Sumar(int a, int b)
			{
				int resultado = a + b;
				Console.WriteLine("Resultado: " + resultado);
			}
			Console.WriteLine("Ingrese un numero");
			int num1 = int.Parse(Console.ReadLine());
			Console.WriteLine("Ingrese otro numero");
			int num2 = int.Parse(Console.ReadLine());
			Sumar(num1, num2);

		}
	}
}
