using System;

namespace Ejercicio17
{
	/// <summary>
	/// Subclase de Persona
	/// </summary>
	public class Alumno:Persona
	{
		int Legajo;
		double Promedio;
		public Alumno(string Nombre, int Dni, int Legajo, double Promedio):base(Nombre, Dni)
		{
			this.Legajo = Legajo;
			this.Promedio = Promedio;
		}
		public int getLegajo
		{
			get{return this.Legajo;}
		}
		public override string ToString()
    	{
         	return "Nombre: " + Nombre + " DNI: " + Dni + " Legajo: " + Legajo + " Promedio: " + Promedio;
    	}
	}
}
