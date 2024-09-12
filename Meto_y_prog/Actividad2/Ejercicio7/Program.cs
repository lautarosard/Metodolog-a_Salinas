/*
 * User: lauta
 * Date: 11/9/2024
 */
using System;

namespace Ejercicio7
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
		public void imprimirElementos(IIterador m)
		{
			if(!m.fin())
			{
				Console.WriteLine(m.actual());
				m.siguiente();
			}
			
		}
	}
}