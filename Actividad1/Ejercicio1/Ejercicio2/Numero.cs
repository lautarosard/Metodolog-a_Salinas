/*
 * Created by SharpDevelop.
 * User: lauta
 * Date: 30/08/2024
 * Time: 03:24 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Ejercicio2
{
	public class Numero
	{
		private int valor;
		
	//Constructores	
		public Numero()
		{
		}
		public Numero(int valor)
		{
			this.valor = valor;
		}
	//Propiedades
			
		public int Valor
		{
			get{return valor;}
			set{this.valor=value;}
		}
	}
}
