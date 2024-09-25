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

namespace Ejercicio14
{
	public class Cola:IColeccionable, IIterable
	{
		private List<IComparable> Datos;
	//constructor	
		public Cola()
		{
			 Datos = new List<IComparable>();
		}
	//Propiedades
	public void Encolar (IComparable elem)
	{
		this.Datos.Add(elem);
	}
	
	public IComparable Desencolar()
	{
		if(EsVacia())
		{
		
			throw new InvalidOperationException("La cola está vacía.");	
		}
		else{
			IComparable temp = this.Datos[0];
			this.Datos.RemoveAt(0);
			return temp;
		}
	}
	
	public IComparable Tope()
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
		this.Encolar(m);
		
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
	public IIterador crearIterador()
	{
		return new IteradorLista(Datos);
	}
 }
}