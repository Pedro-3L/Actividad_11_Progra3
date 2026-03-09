using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_19
{
	internal class Program
	{
		static void Main(string[] args)
		{
			bool EsMultiplo(int a, int b )
			{
				return a % b == 0;
			}

			Console.WriteLine("Ingrese un numero:");
			int numero1 = int.Parse(Console.ReadLine());


			Console.WriteLine("Ingrese otro numero:");
			int numero2 = int.Parse(Console.ReadLine());

			bool resultado = EsMultiplo(numero1, numero2);

			Console.WriteLine("¿El numero " + numero1 + " es multiplo de " + numero2+"?: " + resultado);
		}
	}
}
