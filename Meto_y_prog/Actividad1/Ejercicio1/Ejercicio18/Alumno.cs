using System;

namespace Ejercicio18
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
		public int legajo
		{
			get{return this.Legajo;}
			set{this.Legajo = value;}
		}
		public double promedio
		{
			get{return this.Promedio;}
			set{this.Promedio = value;}
		}
		//metodo para imprimir en forma de string un obj. Alumno
		public override string ToString()
    	{
         	return "Nombre: " + Nombre + " DNI: " + Dni + " Legajo: " + Legajo + " Promedio: " + Promedio;
    	}
		//Reimplementación de metodos
		public override bool SosIgual(IComparable C)
		{
			return this.Dni == ((Persona)C).Dni;
		}
		
		public override bool SosMenor(IComparable C)
		{
			Alumno alu = (Alumno)C;
			return this.promedio < alu.promedio;
		}
		
		public override bool SosMayor(IComparable C)
		{
			Alumno alu = (Alumno)C;
			return this.promedio > alu.promedio;
		}
		
	}
}
