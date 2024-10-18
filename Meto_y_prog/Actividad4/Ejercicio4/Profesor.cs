/*
 * User: lauta
 * Date: 7/9/2024
 */
using System;
using System.Collections.Generic;

namespace Ejercicio4
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
			return Estrategia.sosIgual(this,(IPersona)C);
		}
		
		public bool SosMenor(IComparable C)
		{
			Profesor profe = (Profesor)C;
			return Estrategia.sosMenor(this,(IPersona)C);
		}
		
		public bool SosMayor(IComparable C)
		{
			Profesor profe = (Profesor)C;
			return Estrategia.sosMayor(this,(IPersona)C);
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
