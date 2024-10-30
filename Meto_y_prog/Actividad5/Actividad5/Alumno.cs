using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio1
{
	/// <summary>
	/// Subclase de Persona
	/// </summary>
	public class Alumno:IPersona, IObservador, IAlumno
	{
		private int Legajo;
		private double Promedio;
		private int calificacion;
		private IEstrategiaComparacion Estrategia;
		//constructor
		public Alumno(string Nombre, int Dni, int Legajo, double Promedio)
		{
			this.Legajo = Legajo;
			this.Promedio = Promedio;
			this.Estrategia = new CompararDni();
		}
		//propiedades
		public string getnombre()
		{
			return this.Nombre;
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
		public int calificacion
		{
			get{return this.calificacion;}
			set{this.calificacion = value;}
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
		//Metodos
		public void prestarAtencion()
		{
			Console.WriteLine("Prestando atención");
		}
		public void distraerse()
		{
			Random Ran= new Random();
			int op = Ran.Next(3);
			switch(op){
				case 0:
					Console.WriteLine("Mirando el celular");
					break;
				case 1:
					Console.WriteLine("Dibujando en el margen de la carpeta");
					break;
				case 2:
					Console.WriteLine("Tirando aviones de papel");
					break;
			}
		}
		public void actualizar(IObservado o)
		{
			if(((Profesor)o).isHablando)
			{
				this.prestarAtencion();
			}else
			{
				this.distraerse();
			}
		}
		public virtual int responderPregunta(int pregunta)
		{
			Random ram = new Random();
			int res;
			return res= ram.Next(1,3);
		}
		public string motrarCalificacion()
		{
			return this.Nombre + (String)this.promedio;
		}
	}
}
