﻿/*
 * User: lauta
 * Date: 7/9/2024
 */
using System;
using Ejercicio6;
namespace Ejercicio6
{
	/// <summary>
	/// Description of FabricaDeComparables.
	/// </summary>
	public abstract class FabricaDeComparables
	{
		public FabricaDeComparables()
		{
		}
		public abstract IComparable crearAleatorio();
		public abstract IComparable crearPorTeclado();
		
		protected GeneradorDeDatosAleateorio Generador= new GeneradorDeDatosAleateorio();

		public static IComparable crearAleatorio(int opcion)
		{
			FabricaDeComparables fabrica = null;
			switch(opcion)
			{
				case 1:
					fabrica = new FabricaDeNumeros();
					break;
				case 2:
					fabrica = new FabricasDeAlumnos();
					break;
				default:	
					break;
			}
			return fabrica.crearAleatorio();
		}

		public static IComparable crearPorTeclado(int opcion)
		{
			FabricaDeComparables fabrica = null;
			switch(opcion)
			{
				case 1:
					fabrica = new FabricaDeNumeros();
					break;
				case 2:
					fabrica = new FabricasDeAlumnos();
					break;
				default:	
					break;
			}
			return fabrica.crearPorTeclado();
		}
	}
}
