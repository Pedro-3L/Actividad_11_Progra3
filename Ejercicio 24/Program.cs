using System;

namespace Ejercicio_24
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int Factorial(int n)
			{
				int resultado = 1;

				for (int i = 1; i <= n; i++)
				{
					resultado *= i;
				}

				return resultado;
			}

			Console.WriteLine("Ingrese un numero:");
			int numero = int.Parse(Console.ReadLine());

			int r = Factorial(numero);

			Console.WriteLine("El factorial de " + numero + " es: " + r);
		}
	}
}
