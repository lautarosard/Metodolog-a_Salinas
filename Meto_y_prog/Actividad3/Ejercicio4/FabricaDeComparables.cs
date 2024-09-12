/*
 * User: lauta
 * Date: 7/9/2024
 */
using System;

namespace Ejercicio4
{
	/// <summary>
	/// Description of FabricaDeComparables.
	/// </summary>
	public abstract class FabricaDeComparables
	{
		public FabricaDeComparables()
		{
		}
		protected GeneradorDeDatosAleateorio Generador= new GeneradorDeDatosAleateorio();
		public static IComparable crearAleatorio(int opcion)
		{
			protected FabricaDeComparables fabrica = null;
			switch(opcion)
			{
				case 1:
					fabrica = new FabricaDeNumero();
					break;
				case 2:
					fabrica = new FabricaDePersonas();
					break;
				case 3:
					fabrica = new FabricaDeAlumnos();
					break;
				default:	
					break;
			}
			return fabrica.crearAleatorio();
		}
		public abstract IComparable crearAleatorio();
		public IComparable crearPorTeclado(int opcion);
	}
}
