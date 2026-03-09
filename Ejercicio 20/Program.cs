using System;

namespace Ejercicio_20
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int ContarLetras(string texto)
			{
				return texto.Length;
			}

			Console.WriteLine("Ingrese un texto:");
			string t = Console.ReadLine();

			int cantidad = ContarLetras(t);

			Console.WriteLine("La cantidad de caracteres es: " + cantidad);

		}
	}
}