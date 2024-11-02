/*
 * User: lauta
 * Date: 31/10/2024
 */
using System;

namespace Ejercicio10
{
	/// <summary>
	/// Description of FabricaDePilas.
	/// </summary>
	public class FabricaDePilas:FabricaDeColecciones
	{
		public FabricaDePilas()
		{
		}
		
		public override IColeccionable crearColeccion()
		{
			return new Pila();
		}
	}
}
