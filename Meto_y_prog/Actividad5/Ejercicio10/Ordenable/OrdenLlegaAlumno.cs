/*
 * User: lauta
 * Date: 28/9/2024
 */
using System;

namespace Ejercicio10
{
	/// <summary>
	/// Description of OrdenLlegaAlumno.
	/// </summary>
	public class OrdenLlegaAlumno:OrdenEnAula2
	{
		private Aula aula;
		//
		public OrdenLlegaAlumno(Aula aula)
		{
			this.aula = aula;
		}
		//
		public void ejecutar(AlumnoAdapter alu)
		{
			aula.nuevoAlumno(alu);
		}
	}
}
