using System;

namespace Ejercicio14
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
		public virtual bool SosMenor(IComparable C)
		{ 
			if (this.dni < (((Persona)C).Dni))
			{
				return true;
			}else
			{
				return false;
			}
		}
			
		public virtual bool SosMayor(IComparable C)
		{
			if (this.dni > (((Persona)C).Dni))
			{
				return true;
			}else
			{
				return false;
			}
		}

		public virtual bool SosIgual(IComparable C)
		{
			if(this.dni == (((Persona)C).Dni))
			{
				return true;
			}else
			{
				return false;
			}
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
