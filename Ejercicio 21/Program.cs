using System;

namespace Ejercicio_21
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int ContarVocales(string texto)
			{
				int contador = 0;

				foreach (char c in texto)
				{
					if (c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u' || c == 'A' || c == 'E' || c == 'I' || c == 'O' || c == 'U')
					{
						contador++;
					}
				}

				return contador;
			}

			Console.WriteLine("Ingrese un texto: ");
			string t = Console.ReadLine();

			int cantidad = ContarVocales(t);
			Console.WriteLine("Cantidad de vocales: " + cantidad);


		}
	}
}
