using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_11
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int Sumar(int a, int b)
			{
				return a +b;
			}
			Console.WriteLine("Ingrese un numero");
			int num1 = int.Parse(Console.ReadLine());
			Console.WriteLine("Ingrese otro numero");
			int num2 = int.Parse(Console.ReadLine());
			int resultado = Sumar(num1, num2);
			Console.WriteLine("La suma es: " + resultado);
		}
	}
}
