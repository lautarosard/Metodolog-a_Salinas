/*
 * User: lauta
 * Date: 11/9/2024
 */
using System;

namespace Ejercicio8
{
	class Program
	{
		public static void Main(string[] args)
		{
			//
			Pila pila = new Pila();
			Cola cola = new Cola();
			Conjunto conjunto = new Conjunto();
			Diccionario diccionario = new Diccionario();
			//
			llenarAlumnos(pila);
			llenarAlumnos(cola);
			llenarAlumnos(conjunto);
			llenarAlumnos(diccionario);
			//
			imprimirElemento(pila);
			imprimirElemento(cola);
			imprimirElemento(conjunto);
			imprimirElemento(diccionario);
			//
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
		public static void llenarAlumnos(IColeccionable colec)
		{
			string[] abc= new String[]{"A","B","C","D","E","F","G","H","I","J","K","L","M","N","Ñ","O","P","Q","R","S","T","U","V","W","X","Y","Z"};
			int lg=abc.Length;
			int dni=45308380;
			double Promedio;
			Random Ram= new Random();
			int legajo = Ram.Next(100000,200000);
			
			for (int i=1;i<=20;i++)
			{
				//Numeros random para promedio
				int n1 = Ram.Next(20);
				int n2 = Ram.Next(20);
				Promedio = (n1 + n2)/2;
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
		public void imprimirElementos(IIterador m)
		{
			if(!m.fin())
			{
				Console.WriteLine(m.actual());
				m.siguiente();
			}
			
		}
	}
}