/*
 * User: lauta
 * Date: 17/9/2024
 */
using System;

namespace Ejercicio10
{
	/// <summary>
	/// Description of FabricaDeColas.
	/// </summary>
	public class FabricaDeColas:FabricaDeColecciones
	{
		public FabricaDeColas()
		{
		}
		
		public override IColeccionable crearColeccion()
		{
			return new Cola();
		}
	}
}
