using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_16
{
	internal class Program
	{
		static void Main(string[] args)
		{
			bool EsPositivo(int n)
			{
				return n > 0 ;
			}


			Console.WriteLine("Ingrese un numero:");
			int numero = int.Parse(Console.ReadLine());

			bool resultado = EsPositivo(numero);

			Console.WriteLine("Es positivo? : " + resultado);
		}
	}
}
