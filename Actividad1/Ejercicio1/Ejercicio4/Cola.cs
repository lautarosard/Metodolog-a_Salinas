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
		private List<T> datos = new List<T>();
	//constructor	
		public Cola()
		{
		}
	//Propiedades
	public void Encolar (T elem)
	{
		this.datos.add(elem);
	}
	
	public T Desencolar()
	{
		T temp = this.datos[0];
		this.datos.RemoveAt(0);
		return temp;
	}
	
	public T Tope()
	{
		return this.datos[0];
	}
	public bool esVacia()
	{
		return this.datos.Count == 0;
	}
	
	public int cantidadElementos()
	{
		return this.datos.Count;
	}
	
	}
}
