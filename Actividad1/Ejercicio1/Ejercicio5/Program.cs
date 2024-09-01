/*
 * Created by SharpDevelop.
 * User: lauta
 * Date: 31/08/2024
 * Time: 07:31 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Ejercicio5
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
		public static void llenar(IColeccionable coleccion)
		{
			for (int i=1;i<=20;i++)
			{
				Numero n1 = new Numero(i);
				coleccion.Agregar(n1);
			}
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
		
	}
}