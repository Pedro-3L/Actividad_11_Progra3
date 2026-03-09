using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio7
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int MostrarDoble(int n)
			{
				return 2 * n;
			}
			Console.WriteLine("Ingrese un numero");
			int numero = int.Parse(Console.ReadLine());
			int resultado = MostrarDoble(numero);
			Console.WriteLine("El doble de "+ numero + " es: " + resultado);
		}
	}
}
