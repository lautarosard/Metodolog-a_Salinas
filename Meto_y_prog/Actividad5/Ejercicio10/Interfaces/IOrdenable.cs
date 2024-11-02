/*
 * User: lauta
 * Date: 28/9/2024
 */
using System;

namespace Ejercicio10
{
	/// <summary>
	/// Description of IOrdenable.
	/// </summary>
	public interface IOrdenable
	{
		void setOrdenInicio(OrdenEnAula1 aula);
		void setOrdenLlegaAlumno(OrdenEnAula2 aula);
		void setOrdenAulaLlena(OrdenEnAula1 aula);
	}
}
