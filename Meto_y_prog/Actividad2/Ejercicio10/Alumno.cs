using System;
using System.Collections.Generic;

namespace Ejercicio10
{
	/// <summary>
	/// Subclase de Persona
	/// </summary>
	public class Alumno:Persona
	{
		private int Legajo;
		private double Promedio;
		private IEstrategiaComparacion Estrategia;
		public Alumno(string Nombre, int Dni, int Legajo, double Promedio):base(Nombre, Dni)
		{
			this.Legajo = Legajo;
			this.Promedio = Promedio;
			this.Estrategia = new CompararDni();
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
		
		public void SetEstrategia(IEstrategiaComparacion Estrategia)
		{
			this.Estrategia = Estrategia;
			
		}
		//metodo para imprimir en forma de string un obj. Alumno
		public override string ToString()
    	{
         	return "Nombre: " + Nombre + " DNI: " + Dni + " Legajo: " + Legajo + " Promedio: " + Promedio;
    	}
		//Reimplementación de metodos
		public override bool SosIgual(IComparable C)
		{
			Alumno alu = (Alumno)C;
			return Estrategia.sosIgual(this,alu);
		}
		
		public override bool SosMenor(IComparable C)
		{
			Alumno alu = (Alumno)C;
			return Estrategia.sosMenor(this,alu);
		}
		
		public override bool SosMayor(IComparable C)
		{
			Alumno alu = (Alumno)C;
			return Estrategia.sosMayor(this,alu);
		}
		
	}
}
