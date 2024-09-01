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
using Ejercicio3;

namespace Ejercicio4
{
	public class Cola<T>:IColeccionable
	{
		private List<T> Datos;
	//constructor	
		public Cola()
		{
			 datos = new List<T>();
		}
	//Propiedades
	public void Encolar (T elem)
	{
		this.Datos.Add(elem);
	}
	
	public T Desencolar()
	{
		if(EsVacia())
		{
		
			throw new InvalidOperationException("La cola está vacía.");	
		}
		else{
			T temp = this.datos[0];
			this.Datos.RemoveAt(0);
			return temp;
		}
	}
	
	public T Tope()
	{
		if(EsVacia()){
		
			throw new InvalidOperationException("La cola está vacía.");	
		}
		
		return this.Datos[0];
	}
	public bool EsVacia()
	{
		return this.Datos.Count == 0;
	}
	
	public int CantidadElementos()
	{
		return this.Datos.Count;
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
		this.Encolar(m);
		
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
