using System;
using System.Collections.Generic;

namespace Pract1
{
	//Ejercicio 4
	public class Pila:Icoleccionable
	{
		private List<Icomparable> elementos;
		public Pila()
		{
			this.elementos=new List<Icomparable>();
		}
		public void apilar(Icomparable m)
		{
			elementos.Add(m);
		}
		public Icomparable desapilar ()
		{
			Icomparable aux= elementos[0];
			elementos.RemoveAt(-1);
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
			this.apilar(m);
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
