/*
 * User: lauta
 * Date: 17/9/2024
 */
using System;

namespace Ejercicio14
{
	/// <summary>
	/// Description of FabricaDeColecciones.
	/// </summary>
	public abstract class FabricaDeColecciones
	{
		protected GeneradorDeDatosAleateorio generador= new GeneradorDeDatosAleateorio();
		
		public FabricaDeColecciones()
		{
		}
		
		public abstract IColeccionable crearColeccion();
		
		public static IColeccionable crearColeccion(int opcion)
		{
			FabricaDeColecciones fabrica = null;
			switch(opcion)
			{
				case 1:
					fabrica = new FabricaDeColas();
					break;
				default:	
					break;
				
			}
			return fabrica.crearColeccion();
		}
	}
}
