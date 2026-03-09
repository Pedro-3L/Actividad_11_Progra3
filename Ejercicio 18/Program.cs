using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_18
{
	internal class Program
	{
		static void Main(string[] args)
		{

			int Mayor(int a, int b, int c)
			{
				if (a < b && b<c)
				{
					return a;
				}
				else if (b < a && a < c)
				{
					return b;

				}
				else 
				{
					return c;
				}
			}

			Console.WriteLine("Ingrese un numero:");
			int numero1 = int.Parse(Console.ReadLine());

			Console.WriteLine("Ingrese otro numero:");
			int numero2 = int.Parse(Console.ReadLine());

			Console.WriteLine("Ingrese otro numero:");
			int numero3 = int.Parse(Console.ReadLine());

			int resultado = Mayor(numero1, numero2, numero3);

			Console.WriteLine("El numero menor es " + resultado);
		}
	}
}
