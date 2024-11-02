/*
 * User: lauta
 * Date: 28/9/2024
 */
using System;

namespace Ejercicio10
{
	/// <summary>
	/// Description of AlumnoProxy.
	/// </summary>
	public class AlumnoProxy:IAlumno
	{
		private IAlumno alumnoReal=null;
		private string nombre;
		private int opcion;
		//Constructor
		public AlumnoProxy(string nombre, int opcion)
		{
			this.nombre = nombre;
			this.opcion = opcion;
		}
		//Propiedades/comportamiento de proxy
		public string Nombre
		{
			get{return nombre;}
			set{this.nombre = value;}
		}
		//Propiedades
		public int Legajo
		{
			get{return alumnoReal.Legajo;}
		}
		public double Promedio
		{
			get{return alumnoReal.Promedio;}
		}
		public int Calificacion
		{
			get{return alumnoReal.Calificacion;}
			set{alumnoReal.Calificacion = value;}
		}
		public int Dni
		{
			get{return alumnoReal.Dni;}
		}
		//Delegan Comportamientos 
		public void asegurarAlumno()
		{	
			if(alumnoReal == null)
			{
				alumnoReal =(IAlumno)FabricaDeComparables.crearAleatorio(opcion);
				alumnoReal.Nombre = nombre;
			}
		}
		public void prestarAtencion()
		{
			asegurarAlumno();
			Console.WriteLine("Prestando atención");
		}
		public void distraerse()
		{
			asegurarAlumno();
			alumnoReal.distraerse();
		}
		public void actualizar(IObservado o)
		{
			asegurarAlumno();
			alumnoReal.actualizar(o);
		}
		
		public bool SosIgual(IComparable c)
		{
			try 
			{	
				asegurarAlumno();
				return alumnoReal.Dni == ((IAlumno)c).Dni;
			
			} catch (Exception)
			{
				Console.WriteLine("ERROR; " + "TIPO DE DATO DE C; "+c.GetType()+"\n TIPO DE DATO DE ALUREAL; "+alumnoReal.GetType());
				return false;
			}
		}
		
		public bool SosMenor(IComparable c)
		{
			try 
			{
				asegurarAlumno();
				return alumnoReal.Dni > ((IAlumno)c).Dni;
			
			} catch (Exception) 
			{
				
				Console.WriteLine("ERROR; " + "TIPO DE DATO DE C; "+c.GetType()+"\n TIPO DE DATO DE ALUREAL; "+alumnoReal.GetType());
				return false;
				throw;
			}
			
		}
		
		public bool SosMayor(IComparable c)
		{
			try 
			{
				asegurarAlumno();
				return alumnoReal.Dni < ((IAlumno)c).Dni;
			
			} catch (Exception) 
			{
				
				Console.WriteLine("ERROR; " + "TIPO DE DATO DE C; "+c.GetType()+"\n TIPO DE DATO DE ALUREAL; "+alumnoReal.GetType());
				return false;
				throw;
			}
		}
		
		public int responderPregunta(int pregunta)
		{
			asegurarAlumno();
			return alumnoReal.responderPregunta(pregunta);
		}
		public string mostrarCalificacion()
		{
			
			return alumnoReal.mostrarCalificacion();
		}
	}
}
