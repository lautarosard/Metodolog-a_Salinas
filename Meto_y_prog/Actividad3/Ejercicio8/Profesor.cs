/*
 * User: lauta
 * Date: 7/9/2024
 */
using System;

namespace Ejercicio8
{
	/// <summary>
	/// Description of Profesor.
	/// </summary>
	public class Profesor:Persona
	{
		private int antiguedad;
		public Profesor(string nombre, int dni, int antiguedad):base(nombre,dni)
		{
			this.antiguedad=antiguedad;
			
		}
		public void hablarEnClase()
		{
			Console.WriteLine("Hablando de algún tema");
		}
		public void escribirEnElPizarron()
		{
			Console.WriteLine("Escribiendo en el pizarrón");
		}
		
		
	}
}
