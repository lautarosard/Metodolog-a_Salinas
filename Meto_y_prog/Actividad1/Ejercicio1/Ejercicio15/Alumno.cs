using System;

namespace Ejercicio15
{
	/// <summary>
	/// Subclase de Persona
	/// </summary>
	public class Alumno:Persona
	{
		int Legajo;
		double Promedio;
		public Alumno(int Legajo, double Promedio):base(Nombre, Dni)
		{
			this.Legajo = Legajo;
			this.Promedio = Promedio;
			this.Nombre = Nombre;
			this.Dni = Dni;
		}
		public int getLegajo
		{
			get{return this.Legajo;}
		}
	}
}
