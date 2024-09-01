using System;

namespace Pract1
{
	public class Persona:Icomparable
	{
		protected string nombre;
		protected int dni;
		
		public Persona(string n, int d)
		{
			this.nombre=n;
			this.dni=d;
		}
		public string getNombre()
		{
			return nombre;
		}
		public int getDni()
		{
			return dni;
		}
		public bool sosMenor(Icomparable m)
		{
			if (this.dni<((Persona)m).getDni())
			{
				return true;
			}
			else
			{
				return false;
			}
		}
		public bool sosMayor(Icomparable m)
		{
			
			if (this.dni>((Persona)m).getDni())
			{
				return true;
			}
			else
			{
				return false;
			}
		}
		public bool sosIgual(Icomparable m)
		{
			if (this.dni==((Persona)m).getDni())
			{
				return true;
			}
			else
			{
				return false;
			}
		}
		public override string ToString()
		{
			//return string.Format("[Numero Valor={0}]", valor);
			return this.dni.ToString();
		}
	}
}