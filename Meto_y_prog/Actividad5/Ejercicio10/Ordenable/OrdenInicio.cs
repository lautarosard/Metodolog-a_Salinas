/*
 * User: lauta
 * Date: 28/9/2024
 */
using System;

namespace Ejercicio10
{
	/// <summary>
	/// Description of OrdenInicio.
	/// </summary>
	public class OrdenInicio:OrdenEnAula1
	{
		private Aula aula;
		//
		public OrdenInicio(Aula aula)
		{
			this.aula = aula;
		}
		//
		public void ejecutar()
		{
			aula.Comenzar();
		}
	}
}
