/*
 * User: lauta
 * Date: 12/10/2024
 */
using System;

namespace Ejercicio8
{
	/// <summary>
	/// Description of LegajoDecorator.
	/// </summary>
	public class LegajoDecorator: AlumnoDecorator
	{
		public LegajoDecorator(IAlumno alumno):base(alumno)
		{
		}
		public override string motrarCalificacion()
		{
			//Comportamiento base
			string resultado = base.motrarCalificacion();
			
			//Comportamiento adicional
			return string.Format("({1}) {0}",resultado, this.Legajo);
		}
	}
}
