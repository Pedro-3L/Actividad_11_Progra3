using System;

namespace Ejercicio_15
{
	internal class Program
	{
		static void Main(string[] args)
		{
			bool EsPar(int n)
			{
				return n % 2 == 0;
			}


			Console.WriteLine("Ingrese un numero:");
			int numero = int.Parse(Console.ReadLine());

			bool resultado = EsPar(numero);

			Console.WriteLine("¿Es par?: " + resultado);

		}
	}
}
