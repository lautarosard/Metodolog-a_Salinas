/*
 * User: lauta
 * Date: 12/10/2024
 */
using System;

namespace Ejercicio8
{
	/// <summary>
	/// Description of AsteriscosDecorator.
	/// </summary>
	public class AsteriscosDecorator:AlumnoDecorator
	{
		public AsteriscosDecorator(IAlumno alumno):base(alumno)
		{
		}
		
		public override string motrarCalificacion()
		{
			string resultado = base.motrarCalificacion();
			int longitud = resultado.Length;
			
			string asteriscos="*";
			for(int i=0; i < longitud; i++)
			{
				asteriscos += "*";
			}
			asteriscos += "*****";
			return string.Format("{0}\n*  {1}  *\n{0}", asteriscos, resultado); 
		}

	}
}
