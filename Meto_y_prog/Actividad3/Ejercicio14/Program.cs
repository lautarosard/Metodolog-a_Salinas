/*
 * User: lauta
 * Date: 22/9/2024
 */
using System;

namespace Ejercicio14
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Crear Profe");
			Profesor profe = (Profesor)FabricaDeComparables.crearAleatorio(3);
			
			Console.WriteLine("Crear ALu");
			IComparable Alu = FabricaDeComparables.crearAleatorio(2);
			
			IColeccionable cola = FabricaDeColecciones.crearColeccion(1);
			
			llenar(profe, 2);
			
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
                
				profe.escribirEnElPizarron();
			}
		}
		public static void llenar(Profesor profe, int opcion)
		{
			for(int i = 0; i < 20;i++)
			{
				IComparable Comparable = FabricaDeComparables.crearAleatorio(opcion);
				profe.agregarObsevador((IObservador)Comparable);
			}
		}
	}
}