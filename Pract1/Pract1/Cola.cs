using System;
using System.Collections;
using System.Collections.Generic;
namespace Pract1
{

	//Ejercicio 4
	public class Cola:Icoleccionable
	{
		private List<Icomparable> elementos;
		public Cola()
		{
			this.elementos=new List<Icomparable>();
		}
		public void encolar(Icomparable m)
		{
			this.elementos.Add(m);
		}
		public Icomparable desencolar()
		{
			Icomparable aux= elementos[0];
			elementos.RemoveAt(0);
			return aux;
		}
		public int cuantos()
		{
			return elementos.Count;
		}
		public Icomparable minimo()
		{
			Icomparable min=elementos[0];
			foreach (Icomparable com in elementos)
			{
				if (min.sosMayor(com))
				{
					min=com;
				}
			}
			return min;
		}
		public Icomparable maximo()
		{
			Icomparable max=elementos[0];
			foreach (Icomparable com in elementos)
			{
				if (max.sosMenor(com))
				{
					max = com;
				}
			}
			return max;
		}
		public void agregar(Icomparable m)
		{
			this.encolar(m);
		}
		
		public bool contiene(Icomparable m)
		{
			foreach (Icomparable com in elementos)
			{
				if (com.sosIgual(m))
				{
					return true;
				}
			}
			return false;
		}
		
		
	}
}
