/*
 * User: lauta
 * Date: 28/9/2024
 */
using System;

namespace Ejercicio10
{
	/// <summary>
	/// Description of OrdenAulaLlena.
	/// </summary>
	public class OrdenAulaLlena:OrdenEnAula1
	{
		Aula aula;
		public OrdenAulaLlena(Aula aula)
		{
			this.aula = aula;
		}
		public void ejecutar()
		{
			aula.claseLista();
		}
	}
}
