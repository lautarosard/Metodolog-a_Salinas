/*
 * User: lauta
 * Date: 7/9/2024
 */
using System;
using System.Collections.Generic;

namespace Ejercicio8
{
	public class Diccionario:IColeccionable, IIterable
	{
		//Metodos
		private Conjunto elementos;
		public Diccionario()
		{
			this.elementos = new Conjunto();
		}
		//Metodos
		public void agregar(int clave, IComparable valor)
		{
			ClaveValor claveVal = new ClaveValor(clave,valor);
			if(!Contiene(claveVal))
			{
				elementos.agregar(claveVal);
			}else
			{
				Console.WriteLine("El elemento ya esta en la lista");
			}
		}
		public void Agregar(IComparable m)
		{
			
		}
		public IComparable ValorDe(int clave)
		{
			foreach(ClaveValor cl in elementos.Elementos)
			{
				if(cl.Clave == clave)
				{
					return cl.Valor;
				}
			}
			return null;
		}
		//metodos Icollec
	
		public int Cuantos()
		{
			return elementos.Cuantos();;
		}
		
		public IComparable Minimo()
		{
			return elementos.Minimo();
		}
		
		public IComparable Maximo()
		{
			return elementos.Maximo();
		}
		
		public bool Contiene(IComparable m)
		{
			return elementos.pertenece(m);
			
		}
		
		//Metodo Iterable
		public IIterador crearIterador()
		{
			return new IteradorLista(elementos.Elementos);
		}
	}
}
