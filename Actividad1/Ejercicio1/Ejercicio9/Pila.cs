/*
 * Created by SharpDevelop.
 * User: lauta
 * Date: 30/08/2024
 * Time: 04:18 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;

namespace Ejercicio9
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
		IComparable aux = Datos[0];
		Datos.RemoveAt(-1);
		return aux;
	}
	//metodos Icollec

	public int Cuantos()
	{
		return Datos.Count;
	}
	
	public IComparable Minimo(IComparable C)
	{
		IComparable min = Datos[0];
		foreach (IComparable com in Datos)
		{
			if (min.SosMayor(com))
			{
				min=com;
			}
		}
	}
	public IComparable Maximo(IComparable C)
	{
		IComparable max = Datos[0];
		foreach (IComparable com in Datos)
		{
			if (max.SosMenor(com))
			{
				max = com;
			}
		}
	}
	
	public void Agregar(IComparable m)
	{
		this.Apilar(m);
		
	}
	
	public bool Contiene(IComparable m)
	{
		foreach (IComparable com in Datos)
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
