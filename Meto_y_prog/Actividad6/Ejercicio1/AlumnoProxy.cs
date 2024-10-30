/*
 * User: lauta
 * Date: 17/10/2024
 */
using System;

namespace Ejercicio1
{
	/// <summary>
	/// Description of AlumnoProxy.
	/// </summary>
	public class AlumnoProxy : IAlumno
	{
		IAlumno alumnoReal = null;
		string nombre;
		int opcion;
		
		public AlumnoProxy(string nombre, int opcion)
		{
			this.nombre=nombre;
			this.opcion=opcion;
		}
		
		//Proxy
		public string Nombre
		{
			get{ return nombre;}
			set{ nombre = ValueTuple;}
		}
		
		//Propiedades aluReal
		public int Calificacion
		{
			get{return alumnoReal.Calificacion;}
			set{alumnoReal.Calificacion = value;}
		}
		public int Dni
		{
			get{return alumnoReal.Dni;}
		}
		public double Promedio
		{
			get{return alumnoReal.Promedio;}
		}
		public int Legajo
		{
			get{return alumnoReal.Legajo;}
		}
		
		//delegar comportamientos a aluReal
		public bool SosIgual(IComparable C)
		{
			if(alumnoReal == null)
			{
				alumnoReal = (IAlumno)FabricaDeComparables.crearAleatorio(1);
			}
			return alumnoReal.sosIgual(C);
		}
		public bool SosMenor(IComparable C)
		{
			if(alumnoReal == null)
			{
				alumnoReal = (IAlumno)FabricaDeComparables.crearAleatorio(1);
			}
			return alumnoReal.sosMenor(C);
		}
		public bool SosMayor(IComparable C)
		{
			if(alumnoReal == null)
			{
				alumnoReal = (IAlumno)FabricaDeComparables.crearAleatorio(1);
			}
			return alumnoReal.sosMayor(C);
			
		}
		public void prestarAtencion()
		{
			if(alumnoReal == null)
			{
				alumnoReal = (IAlumno)FabricaDeComparables.crearAleatorio(1);
			}
			alumnoReal.prestarAtencion();
			
		}
		void distraerse()
		{
			if(alumnoReal == null)
			{
				alumnoReal = (IAlumno)FabricaDeComparables.crearAleatorio(1);
			}
			alumnoReal.distraerse();
			
		}
		void actualizar(IObservado o)
		{
			if(alumnoReal == null)
			{
				alumnoReal = (IAlumno)FabricaDeComparables.crearAleatorio(1);
			}
			alumnoReal.actualizar(o);
			
		}
		public bool responderPregunta(int pregunta )
		{
			if(alumnoReal == null)
			{
				alumnoReal = (IAlumno)FabricaDeComparables.crearAleatorio(1);
			}
			return alumnoReal.responderPregunta(pregunta);
			
		}
		public string motrarCalificacion()
		{
			if(alumnoReal == null)
			{
				alumnoReal = (IAlumno)FabricaDeComparables.crearAleatorio(1);
			}
			return alumnoReal.motrarCalificacion();
		}
	}
}
