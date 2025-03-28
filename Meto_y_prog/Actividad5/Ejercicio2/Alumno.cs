﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio2
{
	/// <summary>
	/// Subclase de Persona
	/// </summary>
	public class Alumno:IObservador,IAlumno
	{
		
		private string nombre;
		private int dni;
		private int legajo;
		private double promedio;
		private int calificacion;
		private IEstrategiaComparacion Estrategia;
		//constructor
		public Alumno(string Nombre, int Dni, int Legajo, double Promedio)
		{
			this.nombre =Nombre;
			this.dni = Dni;
			this.Legajo = Legajo;
			this.Promedio = Promedio;
			this.Estrategia = new CompararDni();
		}
		//propiedades
		public int Legajo
		{
			get{return this.legajo;}
			set{this.legajo = value;}
		}
		public double Promedio
		{
			get{return this.promedio;}
			set{this.promedio = value;}
		}
		public int Calificacion
		{
			get{return this.calificacion;}
			set{this.calificacion = value;}
		}
		
		public string Nombre
		{
			get{return nombre;}
			set{this.nombre = value;}
		}
		public int Dni
		{
			get{return dni;}
			set{this.dni = value;}
		}
		public void SetEstrategia(IEstrategiaComparacion Estrategia)
		{
			this.Estrategia = Estrategia;
			
		}
		//metodo para imprimir en forma de string un obj. Alumno
		public override string ToString()
    	{
         	return "Nombre: " + Nombre + " DNI: " + Dni + " Legajo: " + Legajo + " Promedio: " + Promedio + "Calificación: " + calificacion;
    	}
		//Reimplementación de metodos
		public bool SosIgual(IComparable C)
		{
			if(C is IAlumno)
			{
				Alumno alu = (Alumno)C;
				return Estrategia.sosIgual(this,alu);
			}
			return false;
		}
		
		public bool SosMenor(IComparable C)
		{
			if(C is IAlumno)
			{
				Alumno alu = (Alumno)C;
				return Estrategia.sosMenor(this,alu);
			}
			return false;
		}
		
		public bool SosMayor(IComparable C)
		{
			if(C is IAlumno)
			{
				Alumno alu = (Alumno)C;
				return Estrategia.sosMayor(this,alu);
			}
			return false;
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
			if(((Profesor)o).isHablando())
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
		public string mostrarCalificacion()
		{
			return this.Nombre + this.calificacion;
		}
	}
}