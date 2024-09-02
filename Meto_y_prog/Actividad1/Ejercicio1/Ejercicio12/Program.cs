/*
 * Created by SharpDevelop.
 * User: lauta
 * Date: 1/9/2024
 * Time: 20:32
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio12
{
	class Program
	{
		public static void Main(string[] args)
		{
			Cola C1 = new Cola();
			llenarPersonas(C1);
			while(!C1.EsVacia())
			{
				
				Persona Person = (Persona)C1.Desencolar();
				Console.WriteLine("Nombre: " + Person.Nombre + " DNI: " + Person.Dni);
			}
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
		
		public static void llenarPersonas(IColeccionable coleccion)
		{
			string[] abc= new String[]{"A","B","C","D","E","F","G","H","I","J","K","L","M","N","Ñ","O","P","Q","R","S","T","U","V","W","X"};
			int lg=abc.Length;
			int dni=45308380;
			Random Ram= new Random();
			
			for (int i=1;i<=20;i++)
			{
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
				Persona Pers = new Persona(nombre,dni+i);
				coleccion.Agregar(Pers);
			}
		}
	}
}