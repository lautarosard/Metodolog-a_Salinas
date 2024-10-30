/*
 * User: lauta
 * Date: 28/9/2024
 */
using System;

namespace Ejercicio3
{
	/// <summary>
	/// Description of JuegoDeCartas.
	/// </summary>
	public abstract class JuegoDeCartas
	{
		public JuegoDeCartas()
		{
		}
		public void jugar()
		{
			mezclarMazo();
			repartirCartas();
			while(quedanCartas())
			{
				tomarCartas();
				descartarCartas();
			}
			verificarGanador();
		}
		//Se instancia aca porque es comun entre las clases JuegoDeCartas, los demas se los delega a las demas clases
		public void mezclarMazo()
		{
			Console.WriteLine("Estoy mezclando las cartas");
		}
		public abstract void repartirCartas();
		public abstract bool quedanCartas();
		public abstract void tomarCartas();
		public abstract void descartarCartas();
		public abstract void verificarGanador();
			
	}
}
