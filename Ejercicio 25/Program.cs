using System;

namespace Ejercicio_25
{
	internal class Program
	{
		static void Main(string[] args)
		{
			bool EsPrimo(int n)
			{
				if (n <= 1)
				{
					return false;
				}

				for (int i = 2; i < n; i++)
				{
					if (n % i == 0)
					{
						return false;
					}
				}

				return true;
			}

			Console.WriteLine("Ingrese un numero:");
			int numero = int.Parse(Console.ReadLine());

			bool r = EsPrimo(numero);

			if (r)
			{
				Console.WriteLine("El numero es primo");
			}
			else
			{
				Console.WriteLine("El numero no es primo");
			}

		}
	}
}
