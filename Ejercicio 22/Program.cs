using System;

namespace Ejercicio_22
{
	internal class Program
	{
		static void Main(string[] args)
		{
			string Repetir(string texto, int veces)
			{
				string resultado = "";

				for (int i = 0; i < veces; i++)
				{
					resultado += texto + "\n";
				}

				return resultado;
			}

			Console.WriteLine("Ingrese un texto:");
			string t = Console.ReadLine();

			Console.WriteLine("Ingrese cuántas veces repetirlo:");
			int v = int.Parse(Console.ReadLine());

			string r = Repetir(t, v);

			Console.WriteLine(r);


		}
	}
}
