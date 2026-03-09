using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio6
{
	internal class Program
	{
		static void Main(string[] args)
		{

			void Saludar(string nombre)
			{
				Console.WriteLine("Hola " + nombre);
			}

			Console.WriteLine("Ingrese un nombre:");
			 string n = Console.ReadLine();
			Saludar(n);

		}
	}
}
