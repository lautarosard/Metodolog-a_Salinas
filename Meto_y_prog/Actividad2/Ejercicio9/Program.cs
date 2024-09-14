/*
 * User: lauta
 * Date: 12/9/2024
 */
using System;

namespace Ejercicio9
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Hello World!");
			
			// TODO: Implement Functionality Here
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
		public static void cambiarEstrategia(IIterable colect, IEstrategiaComparacion estrat)
		{
			IIterador ite = colect.crearIterador();
			ite.primero();
			while(!ite.fin())
			{
				IComparable comp = ite.actual();
				comp.setEstrategia(estrat);
				ite.siguiente();
			}
			
		}
	}
}