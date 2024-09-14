/*
 * User: lauta
 * Date: 12/9/2024
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio10
{
	class Program
	{
		public static void Main(string[] args)
		{
			IEstrategiaComparacion estLegajo = new CompararLegajo();
			IEstrategiaComparacion estNombre = new CompararNombre();
			IEstrategiaComparacion estPromed = new CompararPromedio();
				
			Pila pila = new Pila();
			llenarAlumnos(pila);
			
			Console.WriteLine("Compara por DNI");
			informar(pila);
			cambiarEstrategia(pila, estLegajo);
			
			Console.WriteLine("Compara por legajo");
			informar(pila);
			cambiarEstrategia(pila, estNombre);
			
			Console.WriteLine("Compara por nombre");
			informar(pila);
			cambiarEstrategia(pila, estPromed);
			
			Console.WriteLine("Compara por promedio");
			informar(pila);
			imprimirElemento(pila);
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
		public static void informar (IColeccionable C)
		{
			Console.WriteLine("-----------------------------------");
			Console.WriteLine("Cantidad de alumnos " + C.Cuantos());
			Console.WriteLine("Minimo; " + C.Minimo());
			Console.WriteLine("Maximo; " +C.Maximo());
			Console.WriteLine("-----------------------------------");
			
		}
		
		public static void imprimirElemento(IIterable m)
		{
			IIterador ite = m.crearIterador();
			ite.primero();
			while(!ite.fin())
			{
				Console.WriteLine(ite.actual());
				ite.siguiente();
			}
			
		}
		
		public static void llenarAlumnos(IColeccionable colec)
		{
			string[] abc= new String[]{"A","B","C","D","E","F","G","H","I","J","K","L","M","N","Ñ","O","P","Q","R","S","T","U","V","W","X","Y","Z"};
			int lg=abc.Length;
			int dni=45308380;
			double Promedio;
			Random Ram= new Random();
			int legajo;
			
			for (int i=1;i<=20;i++)
			{
				//Numeros random para promedio
				int n1 = Ram.Next(1,10);
				int n2 = Ram.Next(1,10);
				Promedio = (n1 + n2)/2;
				//Me da numero aleatorios con limite del array de abc
				int ind1=Ram.Next(lg);
				int ind2=Ram.Next(lg);
				//legajo
				legajo = Ram.Next(100000,200000);
				//armar los nombres
				StringBuilder nombresBuild= new StringBuilder();
				nombresBuild.Append(abc[ind1]);
				nombresBuild.Append(abc[ind2]);
				nombresBuild.Append(abc[(ind2+ind1)%lg]);
				nombresBuild.Append(abc[(ind2+ind1+1)%lg]);
				
					
				string nombre = nombresBuild.ToString();
				Alumno Alu = new Alumno(nombre,dni+i,legajo,Promedio);
				colec.Agregar(Alu);
			}
		}
		
		public static void cambiarEstrategia(IIterable colect, IEstrategiaComparacion estrat)
		{
			IIterador ite = colect.crearIterador();
			ite.primero();
			while(!ite.fin())
			{
				Alumno comp = (Alumno)ite.actual();
				comp.SetEstrategia(estrat);
				ite.siguiente();
			}
			
		}
	}
}