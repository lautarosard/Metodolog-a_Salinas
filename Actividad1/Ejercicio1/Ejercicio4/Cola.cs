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
<<<<<<< HEAD
		private List<T> datos = new List<T>();
	//constructor	
		public Cola()
		{
=======
		private List<T> datos;
	//constructor	
		public Cola()
		{
			 datos = new List<T>();
>>>>>>> c5fc32b18f9c41b8be243b8e97e364e0f85201e4
		}
	//Propiedades
	public void Encolar (T elem)
	{
<<<<<<< HEAD
		this.datos.add(elem);
=======
		this.datos.Add(elem);
>>>>>>> c5fc32b18f9c41b8be243b8e97e364e0f85201e4
	}
	
	public T Desencolar()
	{
<<<<<<< HEAD
		T temp = this.datos[0];
		this.datos.RemoveAt(0);
		return temp;
=======
		if(EsVacia()){
		
			throw new InvalidOperationException("La cola está vacía.");	
		}
		else{
			T temp = this.datos[0];
			this.datos.RemoveAt(0);
			return temp;
		}
>>>>>>> c5fc32b18f9c41b8be243b8e97e364e0f85201e4
	}
	
	public T Tope()
	{
<<<<<<< HEAD
		return this.datos[0];
	}
	public bool esVacia()
=======
		if(EsVacia()){
		
			throw new InvalidOperationException("La cola está vacía.");	
		}
		
		return this.datos[0];
	}
	public bool EsVacia()
>>>>>>> c5fc32b18f9c41b8be243b8e97e364e0f85201e4
	{
		return this.datos.Count == 0;
	}
	
<<<<<<< HEAD
	public int cantidadElementos()
=======
	public int CantidadElementos()
>>>>>>> c5fc32b18f9c41b8be243b8e97e364e0f85201e4
	{
		return this.datos.Count;
	}
	
<<<<<<< HEAD
=======
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
	
>>>>>>> c5fc32b18f9c41b8be243b8e97e364e0f85201e4
	}
}
