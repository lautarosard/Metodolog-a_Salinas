/*
 * User: lauta
 * Date: 11/9/2024
 */
using System;
using System.Collections.Generic;

namespace Ejercicio14
{
	/// <summary>
	/// Description of IteradorLista.
	/// </summary>
	public class IteradorLista:IIterador
	{
		private List<IComparable> elementos;
		private int indice;
		
		public IteradorLista(List<IComparable> elementos)
		{
			this.elementos = elementos;
			primero();
		}
		//Metodos
		
		public void primero()
		{
			indice = 0;
		}
		public void siguiente()
		{
			indice++;
		}
		public bool fin()
		{
			return elementos.Count == indice;
		}
		public IComparable actual()
		{
			return elementos[indice];
		}
		
		
	}
}
