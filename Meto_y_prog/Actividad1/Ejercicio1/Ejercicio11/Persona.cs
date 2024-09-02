/*
 * Created by SharpDevelop.
 * User: lauta
 * Date: 1/9/2024
 * Time: 19:38
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Ejercicio11
{
	public class Persona:IComparable
	{
		private string nombre;
		private int dni;
		public Persona(string nombre, int dni)
		{
			this.nombre=nombre;
			this.dni=dni;
		}
		//Metodos
		public bool SosMenor(IComparable C)
		{ 
			if (this.dni < (((Persona)C).Dni()))
			{
				return true;
			}else
			{
				return false;
			}
		}
			
		public bool SosMayor(IComparable c)
		{
			if (this.dni > (((Persona)C).Dni))
			{
				return true;
			}else
			{
				return false;
			}
		}

		public bool SosIgual(IComparable c)
		{
			if(this.dni == (((Persona)C).Dni))
			{
				return true;
			}else
			{
				return false;
			}
		}
		
		//propiedades
		public string Nombre{
			get{return nombre;}
			set{this.nombre = value;}
		}
		public int Dni{
			get{return dni;}
			set{this.dni = value;}
		}
	}
}
