using System;

namespace Ejercicio_10
{
	internal class Program
	{
		static void Main(string[] args)
		{
			void ImprimirRepetido(string texto, int veces)
			{
				for (int i = 0; i < veces; i++)
				{
					Console.WriteLine(texto);
				}
			}

			Console.WriteLine("Ingrese un texto:");
			string t = Console.ReadLine();

			Console.WriteLine("Ingrese cuantas veces quiere imprimirlo:");
			int v = int.Parse(Console.ReadLine());

			ImprimirRepetido(t, v);

		}
	}
}
