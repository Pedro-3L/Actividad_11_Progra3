using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_13
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int Multiplicar(int a, int b)
			{
				return a * b;
			}
			Console.WriteLine("Ingrese un numero");
			int num1 = int.Parse(Console.ReadLine());
			Console.WriteLine("Ingrese otro numero");
			int num2 = int.Parse(Console.ReadLine());
			int resultado = Multiplicar(num1, num2);
			Console.WriteLine("Resultado: " + resultado);
		}
	}
}
