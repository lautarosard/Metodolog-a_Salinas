/*
 * Created by SharpDevelop.
 * User: lauta
 * Date: 31/08/2024
 * Time: 10:00 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Ejercicio9
{
	class Program
	{
		public static void Main(string[] args)
		{
			Pila P1 = new Pila();
			Cola C1 = new Cola();
			
			ColeccionMultiple CM = new ColeccionMultiple(P1,C1);
			
			llenar(P1);
			llenar(C1);
			
			informar(P1);
			informar(C1);
			informar(CM);
			
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
		}
			
		public static void informar (IColeccionable C)
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