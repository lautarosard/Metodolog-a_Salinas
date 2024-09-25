/*
 * User: lauta
 * Date: 7/9/2024
 */
using System;
using System.Collections.Generic;

namespace Ejercicio14
{
	public class Profesor:Persona, IObservado
	{
		private int antiguedad;
		private bool hablando;
		private List<IObservador> observadores = new List<IObservador>();
		private IEstrategiaComparacion Estrategia;
		//
		public Profesor(string nombre, int dni, int antiguedad):base(nombre,dni)
		{
			this.antiguedad=antiguedad;
			this.Estrategia = new CompararDni();
			
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
		public override bool SosIgual(IComparable C)
		{
			return Estrategia.sosIgual(this,(Persona)C);
		}
		
		public override bool SosMenor(IComparable C)
		{
			Profesor profe = (Profesor)C;
			return Estrategia.sosMenor(this,(Persona)C);
		}
		
		public override bool SosMayor(IComparable C)
		{
			Profesor profe = (Profesor)C;
			return Estrategia.sosMayor(this,(Persona)C);
		}
		//metodos observador
		public void agregarObsevador(IObservador observador)
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
