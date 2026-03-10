using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_23
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int SumarDel1AlN( int n)
			{
				int resultado = 0;

				for (int i = 1; i <= n; i++)
				{
					resultado += i;
				}

				return resultado;
			}

			Console.WriteLine("Ingrese un numero:");
			int numero = int.Parse(Console.ReadLine());

			int r = SumarDel1AlN(numero);

			Console.WriteLine("La suma de todos los numeros del 1 a " + numero + " es: " + r);


		}
	}
}
