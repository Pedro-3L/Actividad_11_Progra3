using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_17
{
	internal class Program
	{
		static void Main(string[] args)
		{

			int Mayor(int a, int b)
			{
				if(a>b)
				{
					return a;
				}
				else
				{
					return b;

				}
			}

			Console.WriteLine("Ingrese un numero:");
			int numero1 = int.Parse(Console.ReadLine());

			Console.WriteLine("Ingrese otro numero:");
			int numero2 = int.Parse(Console.ReadLine());

			int resultado = Mayor(numero1, numero2);

			Console.WriteLine("El numero mayor es " + resultado);
		}
	}
}
