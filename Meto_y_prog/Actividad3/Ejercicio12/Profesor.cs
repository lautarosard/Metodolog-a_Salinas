/*
 * User: lauta
 * Date: 7/9/2024
 */
using System;
using System.Collections.Generic;

namespace Ejercicio12
{
	public class Profesor:Persona, IObservado
	{
		private int antiguedad;
		private bool hablando;
		private List<IObservador> observadores;
		public Profesor(string nombre, int dni, int antiguedad):base(nombre,dni)
		{
			this.antiguedad=antiguedad;
			
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
		//metodos observador
		public void agregarObsevardor(IObservador)
		{
			this.observadores.Add(0);
		}
		public void quitarObservador(IObservador O)
		{
			this.observadores.Remove(0);
		}
		public void notificar()
		{
			foreach(var ob in observadores)
			{
				ob.actualizar(this);
			}
		}
		public bool isHablando(){
			get{return hablando;}
		}
	}
}
