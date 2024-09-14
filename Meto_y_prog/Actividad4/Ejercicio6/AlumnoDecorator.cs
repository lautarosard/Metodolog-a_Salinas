/*
 * User: lauta
 * Date: 14/9/2024
 */
using System;

namespace Ejercicio6
{
	/// <summary>
	/// Description of AlumnoDecorator.
	/// </summary>
	public abstract class AlumnoDecorator:IAlumno
	{
		protected IAlumno adicional;
		
		public AlumnoDecorator()
		{
		}
		string getnombre()
		{
			return adicional.getnombre();
		}
		int getlegajo();
		double getpromedio();
		int getcalificacion();
		
		public bool SosIgual(IComparable c);
		public bool SosMenor(IComparable c);
		public bool SosMayor(IComparable c);
		public void prestarAtencion();
		public void distraerse();
		public void actualizar(IObservado o);
		public int responderPregunta(int pregunta);
		public string motrarCalificacion();
	}
}
