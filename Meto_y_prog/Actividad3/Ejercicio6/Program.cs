/*
 * User: lauta
 * Date: 17/9/2024
 */
using System;

namespace Ejercicio6
{
	class Program
	{
		public static void Main(string[] args)
		{	
			IColeccionable cola = FabricaDeColecciones.crearColeccion(1);
			
			
			llenar(cola);
			informar(cola, 1);
			imprimirElemento((Cola)cola);
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
		public static void llenar(IColeccionable coleccion)
		{
			for(int i = 0; i < 20;i++)
			{
				IComparable Comparable = FabricaDeComparables.crearAleatorio(1);
				coleccion.Agregar(Comparable);
			}
		}
		public static void informar(IColeccionable colect, int opcion)
		{
			Console.WriteLine("Cantidad: "+ colect.Cuantos());
			Console.WriteLine("Minimo: "+ colect.Minimo());
			Console.WriteLine("Maximo: "+ colect.Maximo());
			
			IComparable comparable = FabricaDeComparables.crearPorTeclado(opcion);
			
			if(colect.Contiene(comparable))
			{
				Console.WriteLine("El elemento leído está en la colección");
			}else
			{
				Console.WriteLine("El elemento leído no está en la colección");
			}
		}
		public static void imprimirElemento(IIterable m)
		{
			IIterador ite = m.crearIterador();
			ite.primero();
			while(!ite.fin())
			{
				Console.WriteLine(ite.actual());
				ite.siguiente();
			}
			
		}
		
	}
}