/*
 * Created by SharpDevelop.
 * User: lauta
 * Date: 31/08/2024
 * Time: 08:05 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Ejercicio6
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Hello World!");
			
			// TODO: Implement Functionality Here
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
		public void informar (IColeccionable C)
		{
			Console.WriteLine(C.Cuantos());
			Console.WriteLine(C.Minimo());
			Console.WriteLine(C.Maximo());
			IComparable N1 = new Numero(int.Parse(Console.ReadLine));
			if (C.Contiene(N1))
				Console.WriteLine("El elemento leído está en la colección ");
			else
				Console.WriteLine("El elemento leído no está en la colección ");
				

		}
	}
}