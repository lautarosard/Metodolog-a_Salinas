/*
 * Created by SharpDevelop.
 * User: lauta
 * Date: 4/9/2024
 * Time: 19:15
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio18
{
	class Program
	{
		public static void Main(string[] args)
		{
			Cola Cola = new Cola();
			Pila Pila = new Pila();
			
			ColeccionMultiple Multiple = new ColeccionMultiple(Pila,Cola);
			
			llenarPersonas(Cola);
			llenarPersonas(Pila);
			
			informar(Multiple);
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
		public static void llenarPersonas(IColeccionable coleccion)
		{
			string[] abc= new String[]{"A","B","C","D","E","F","G","H","I","J","K","L","M","N","Ñ","O","P","Q","R","S","T","U","V","W","X","Y","Z"};
			int lg=abc.Length;
			int dni=45308380;
			double Promedio;
			int legajo = 112343;
			Random Ram= new Random();
			
			for (int i=1;i<=20;i++)
			{
				//Numeros random para promedio
				int n1 = Ram.Next(10);
				int n2 = Ram.Next(10);
				Promedio = ((n1 + 1) + (n2 + 1))/2;
				
				//Me da numero aleatorios con limite del array de abc
				int ind1=Ram.Next(lg);
				int ind2=Ram.Next(lg);
				
				//armar los nombres
				StringBuilder nombresBuild= new StringBuilder();
				nombresBuild.Append(abc[ind1]);
				nombresBuild.Append(abc[ind2]);
				nombresBuild.Append(abc[(ind2+ind1)%lg]);
				nombresBuild.Append(abc[(ind2+ind1+1)%lg]);
				
				string nombre = nombresBuild.ToString();
				Alumno Alu = new Alumno(nombre,dni+i,legajo,Promedio);
				coleccion.Agregar(Alu);
			}
		}
			public static void informar (IColeccionable C)
		{
				Console.WriteLine(C.Cuantos());
				Console.WriteLine(C.Minimo());
				Console.WriteLine(C.Maximo());
		}
	}
}