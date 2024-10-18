/*
 * User: lauta
 * Date: 14/9/2024
 */
using System;

namespace Ejercicio8
{
	/// <summary>
	/// Description of AlumnoDecorator.
	/// </summary>
	public abstract class AlumnoDecorator:IAlumno
	{
		protected IAlumno adicional;
		
		public AlumnoDecorator(IAlumno adicional)
		{
			this.adicional = adicional;
		}
		//Propiedades
		public string Nombre
		{
			get{return adicional.Nombre;}
		}
		public int Dni
		{
			get{return adicional.Dni;}
		}
		public int Legajo
		{
			get{return adicional.Legajo;}
		}
		public double Promedio
		{
			get{return adicional.Promedio;}
		}
		public int Calificacion
		{
			get{return adicional.Calificacion;}
			set{adicional.Calificacion = value;}
		}
		//Metodos
		public bool SosIgual(IComparable c)
		{
			return adicional.SosIgual(c);
		}
		public bool SosMenor(IComparable c)
		{
			return adicional.SosMenor(c);
		}
		public bool SosMayor(IComparable c)
		{
			return adicional.SosMayor(c);
		}
		public void prestarAtencion()
		{
			adicional.prestarAtencion();
		}
		public void distraerse()
		{
			adicional.prestarAtencion();
		}
		public void actualizar(IObservado o)
		{
			adicional.actualizar(o);
		}
		public int responderPregunta(int pregunta)
		{
			return adicional.responderPregunta(pregunta);
		}
		public virtual string motrarCalificacion()
		{
			return adicional.motrarCalificacion();
		}
	}
}
