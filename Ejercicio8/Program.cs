using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio8
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int MostrarCuadrado(int n)
			{
				return n * n;
			}
			Console.WriteLine("Ingrese un numero");
			int numero = int.Parse(Console.ReadLine());
			int resultado = MostrarCuadrado(numero);
			Console.WriteLine("El cuadrado de " + numero + " es: " + resultado);
		}
	}
}
