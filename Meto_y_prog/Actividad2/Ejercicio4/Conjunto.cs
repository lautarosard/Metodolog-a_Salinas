/*
 * User: lauta
 * Date: 7/9/2024
 */
using System;
using System.Collections.Generic;

namespace Ejercicio4
{
	/// <summary>
	/// Description of Conjunto.
	/// </summary>
	public class Conjunto:IColeccionable
	{
		private List<IComparable> elementos;
		public Conjunto()
		{
		}
		//Metodo
		public void agregar(IComparable elem)
		{
			if(pertenece(elem))
			Agregar(elem);
			
		}
		public bool pertenece(IComparable elem)
		{
			return Contiene(elem);
		}
		
		//metodos Icollec
	
		public int Cuantos()
		{
			return elementos.Count;
		}
		
		public IComparable Minimo()
		{
			IComparable min = elementos[0];
			foreach (IComparable com in elementos)
			{
				if (min.SosMayor(com))
				{
					min=com;
				}
			}
			return min;
		}
		
		public IComparable Maximo()
		{
			IComparable max = elementos[0];
			foreach (IComparable com in elementos)
			{
				if (max.SosMenor(com))
				{
					max = com;
				}
			}
			return max;
		}
		
		private void Agregar(IComparable m)
		{
			elementos.Add(m);
			
		}
		
		private bool Contiene(IComparable m)
		{
			foreach (IComparable com in elementos)
			{
				if (com.SosIgual(m))
				{
					return true;
				}
			}
			return false;
		}
	}
}
