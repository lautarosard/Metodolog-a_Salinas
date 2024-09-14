using System;

namespace Ejercicio8
{
	public class Persona:IComparable
	{
		protected string nombre;
		protected int dni;
		
		public Persona(string nombre, int dni)
		{
			this.nombre=nombre;
			this.dni=dni;
		}
		//Metodos
		public virtual bool SosMenor(IComparable C)
		{ 
			return this.dni < (((Persona)C).Dni);
		}
			
		public virtual bool SosMayor(IComparable C)
		{
			return this.dni > (((Persona)C).Dni);
		}

		public virtual bool SosIgual(IComparable C)
		{
			return this.dni == (((Persona)C).Dni);
		}
		 public override string ToString()
    	{
        	return "Nombre: " + nombre + " DNI: " + dni;
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
