/*
 * User: lauta
 * Date: 20/9/2024
 */
using System;

namespace Ejercicio13
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Crear Profe");
			Profesor profe = (Profesor)FabricaDeComparables.crearAleatorio(3);
			
			Console.WriteLine("Crear ALu");
			IComparable Alu = FabricaDeComparables.crearAleatorio(2);
			
			profe.agregarObsevador((Alumno)Alu);
			dictadoDeClases(profe);
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
		public static void dictadoDeClases(Profesor profe)
		{
			for (int i = 0; i <= 5; i++)
			{
				Console.WriteLine("Entraste a dictaClases");
				profe.hablarEnClase();
				Console.WriteLine("----------------------");
                Console.WriteLine("----------------------");
                Console.WriteLine("----------------------");
				profe.escribirEnElPizarron();
			}
		}
	}
}