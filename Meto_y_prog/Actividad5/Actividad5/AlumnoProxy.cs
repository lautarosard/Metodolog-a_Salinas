/*
 * User: lauta
 * Date: 28/9/2024
 */
using System;

namespace Ejercicio1
{
	/// <summary>
	/// Description of AlumnoProxy.
	/// </summary>
	public class AlumnoProxy:IAlumno
	{
		private IAlumno alumnoReal=null;
		private string nombre;
		//Constructor
		public AlumnoProxy(string nombre)
		{
			this.nombre = nombre;
		}
		//Propiedades
		public string Nombre
		{
			get{return nombre;}
			set{this.nombre = value;}
		}
		public int ResponderPregunta(int pregunta)
		{
			if(alumnoReal==null)
			{
				alumnoReal = FabricaDeComparables.crearAleatorio(1);
				alumnoReal.Nombre = nombre;
			}
			return alumnoReal.responderPregunta(pregunta)
		}
	}
}
