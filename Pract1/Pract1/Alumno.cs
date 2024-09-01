using System;
using System.Collections;
using System.Collections.Generic;
namespace Pract1
{
	public class Alumno:Persona,Icomparable
	{
		private int legajo;
		private int promedio;
		public Alumno(string n,int d, int l, int p):base(n,d)
		{
			legajo=l;
			promedio=p;
		}
		public int getLegajo()
		{
			return legajo;
		}
		public int getPromedio()
		{
			return promedio;
		}
		public bool sosMenor(Icomparable m)
		{
			if (this.promedio<((Alumno)m).getPromedio())
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
			
			if (this.promedio>((Alumno)m).getPromedio())
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
			if (this.promedio==((Alumno)m).getPromedio())
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
			return this.promedio.ToString();
		}
	}
}
