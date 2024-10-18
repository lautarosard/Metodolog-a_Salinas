/*
 * User: lauta
 * Date: 12/10/2024
 */
using System;

namespace Ejercicio8
{
	/// <summary>
	/// Description of CalificacionDecorator.
	/// </summary>
	public class CalificacionDecorator:AlumnoDecorator
	{
		public CalificacionDecorator(IAlumno alumno):base(alumno)
		{
		}
		public override string motrarCalificacion()
		{
			int nota = this.Calificacion;
			string calificacion;
			
			if(nota == 1 || nota ==0)
			{
				calificacion= "(DESAPROBADO)";
			}else if( nota == 2)
			{
				calificacion = "(APROBADO)";
			}else
			{
				calificacion = "(PROMOCIONA)";
			}
			//Comportamiento base
			string resultado = base.motrarCalificacion();
			
			//Comportamiento decorator
			return string.Format("{0} {1}",resultado,calificacion);
			
		}
	}
}
