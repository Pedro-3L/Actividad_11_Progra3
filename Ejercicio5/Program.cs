using System;

namespace Ejercicio5
{
	internal class Program
	{
		static void Main(string[] args)
		{
			void MostrarMenu()
			{
				int opcion;
				Console.WriteLine("1 - Opcion 1");
				Console.WriteLine("2 - Opcion 2");
				Console.WriteLine("3 - Salir");
				opcion = int.Parse(Console.ReadLine());
				switch (opcion)
				{
					case 1:
						Console.WriteLine("Seleccionada opcion 1");
						break;
					case 2:
						Console.WriteLine("Seleccionada opcion 2");
						break;
					case 3:
						Console.WriteLine("Saliendo");
						break;
					default:
						Console.WriteLine("Opcion invalida");
						break;
				}
			}
			MostrarMenu();
		}
	}
}
