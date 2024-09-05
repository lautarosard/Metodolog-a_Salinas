using System;
using System.Collections.Generic;

namespace Ejercicio13
{
	public class Pila:IColeccionable
	{
		private List<IComparable> Datos;
		
		public Pila()
		{
			this.Datos = new List<IComparable>();
		}
	//metodos

	public void Apilar (IComparable d)
	{
		Datos.Add(d);
	}
	
	public IComparable Desapilar()
	{
		IComparable aux = Datos[Datos.Count - 1];
		Datos.RemoveAt(-1);
		return aux;
	}
	//metodos Icollec

	public int Cuantos()
	{
		return Datos.Count;
	}
	
	public IComparable Minimo()
	{
		IComparable min = Datos[0];
		foreach (IComparable com in Datos)
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
		IComparable max = Datos[0];
		foreach (IComparable com in Datos)
		{
			if (max.SosMenor(com))
			{
				max = com;
			}
		}
		return max;
	}
	
	public void Agregar(IComparable m)
	{
		this.Apilar(m);
		
	}
	
	public bool Contiene(IComparable m)
	{
		foreach (IComparable com in Datos)
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
