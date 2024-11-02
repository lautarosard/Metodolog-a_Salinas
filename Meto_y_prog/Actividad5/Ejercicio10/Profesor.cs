/*
 * User: lauta
 * Date: 7/9/2024
 */
using System;
using System.Collections.Generic;

namespace Ejercicio10
{
	public class Profesor:IPersona, IObservado, IComparable
	{
		private int antiguedad;
		private bool hablando;
		private int dni;
		private string nombre;
		private List<IObservador> observadores = new List<IObservador>();
		private IEstrategiaComparacion Estrategia;
		//
		public Profesor(string nombre, int dni, int antiguedad)
		{
			this.antiguedad=antiguedad;
			this.Estrategia = new CompararDni();
			
		}
		//PROPIEDADES
		public int Dni
		{
			get{return dni;}
			set{dni = value;}
		}
		public string Nombre
		{
			get{return nombre;}
			set{nombre = value;}
		}
		public int Antiguedad
		{
			get{return antiguedad;}
			set{antiguedad = value;}
		}
		//Metodos
		public void hablarEnClase()
		{
			hablando = true;
			Console.WriteLine("Hablando de algún tema");
			this.notificar();
		}
		public void escribirEnElPizarron()
		{
			hablando = false;
			Console.WriteLine("Escribiendo en el pizarrón");
		}
		//Metodos de iComparable
		public bool SosIgual(IComparable C)
		{
			return this.antiguedad == ((Profesor)C).Antiguedad;
		}
		
		public bool SosMenor(IComparable C)
		{
			return this.antiguedad < ((Profesor)C).Antiguedad;
		}
		
		public bool SosMayor(IComparable C)
		{
			return this.antiguedad > ((Profesor)C).Antiguedad;
		}
		//metodos observador
		public void agregarObservador(IObservador observador)
		{
			this.observadores.Add(observador);
		}
		public void quitarObservador(IObservador observador)
		{
			this.observadores.Remove(observador);
		}
		public void notificar()
		{
			foreach(var ob in observadores)
			{
				ob.actualizar(this);
			}
		}
		public bool isHablando(){
			return hablando;
		}
	}
}
