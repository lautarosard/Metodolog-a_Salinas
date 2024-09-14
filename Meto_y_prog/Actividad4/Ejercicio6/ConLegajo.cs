/*
 * User: lauta
 * Date: 14/9/2024
 */
using System;

namespace Ejercicio6
{
	/// <summary>
	/// Description of ConLegajo.
	/// </summary>
	public class ConLegajo:AlumnoDecorator
	{
		public ConLegajo(IAlumno adicional)
		{
			this.adicional = adicional;
		}
		
	}
}
