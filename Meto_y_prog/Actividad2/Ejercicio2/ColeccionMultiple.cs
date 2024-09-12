/*
 * Created by SharpDevelop.
 * User: lauta
 * Date: 31/08/2024
 * Time: 08:56 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;

namespace Ejercicio2
{
	public class ColeccionMultiple:IColeccionable
	{
		private Pila P1;
		private Cola C1;
		//Constructor
		public ColeccionMultiple(Pila P1,Cola C1)
		{
			this.P1 = P1;
			this.C1 = C1;
		}
		//Metodos
		
		//metodos Icollec
		public int Cuantos()
		{
			int suma = P1.Cuantos() + C1.Cuantos();
			return suma;
		}
		
		public IComparable Minimo()
		{
			IComparable PiN1 = P1.Minimo();
			IComparable CoN1 = C1.Minimo();
			if (PiN1.SosMenor(CoN1))
			{return PiN1;}
			else
			{return CoN1;}
		}
		
		public IComparable Maximo()
		{
			IComparable PiN1 = P1.Maximo();
			IComparable CoN1 = C1.Maximo();
			if (PiN1.SosMayor(CoN1))
			{return PiN1;}
			else
			{return CoN1;}
		}
		
		public void Agregar(IComparable m)
		{
			//No es necesaario;	
		}
		
		public bool Contiene(IComparable m)
		{
			if (P1.Contiene(m) || C1.Contiene(m))
			{
				return true;
			}
				return false;
		}
 }
}
