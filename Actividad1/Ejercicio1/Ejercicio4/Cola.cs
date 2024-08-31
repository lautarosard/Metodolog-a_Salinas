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
		private List<T> datos;
	//constructor	
		public Cola()
		{
			 datos = new List<T>();
		}
	//Propiedades
	public void Encolar (T elem)
	{
		this.datos.Add(elem);
	}
	
	public T Desencolar()
	{
		if(EsVacia()){
		
			throw new InvalidOperationException("La cola está vacía.");	
		}
		else{
			T temp = this.datos[0];
			this.datos.RemoveAt(0);
			return temp;
		}
	}
	
	public T Tope()
	{
		if(EsVacia()){
		
			throw new InvalidOperationException("La cola está vacía.");	
		}
		
		return this.datos[0];
	}
	public bool EsVacia()
	{
		return this.datos.Count == 0;
	}
	
	public int CantidadElementos()
	{
		return this.datos.Count;
	}
	
	public int Cuantos()
	{
		
	}
	
	public int Minimo()
	{
		
	}
	
	public List<IComparable<t>> Agregar(IComparable)
	{
		
	}
	
	public bool Contiene(IComparable)
	{
		
	}
	
	}
}
