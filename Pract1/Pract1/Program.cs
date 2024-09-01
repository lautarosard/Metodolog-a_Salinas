using System;
using System.Collections;

namespace Pract1
{
	class Program
	{
		//Ejercicio 5
		public static void llenar(Icoleccionable coleccion)
		{
			for (int i=1;i<=20;i++)
			{
				Numero com=new Numero(i);
				coleccion.agregar(com);
			}
			
		}
		//Ejercicio 12
		public static void llenarPersonas(Icoleccionable coleccion)
		{
			string[] nombres = { "Juan", "Ana", "Luis", "Maria", "Carlos", "Laura", "Miguel", "Elena", "Andrés","Leo","Uriel","Luz","Roberto","Nicolas","Samu","Belen","Nahuel","Rosana","Damian","Carmelo"};
			ArrayList dni = new ArrayList(){};
			
			for (int j=44636800;j<=44636819;j++)
			{
				dni.Add(j);
			}
			for (int i=0;i<=19;i++)
			{
				Persona per=new Persona(nombres[i],(int)dni[i]);
				coleccion.agregar(per);
			}
		}
		//Ejercicio 16
		public static void llenaAlumnos(Icoleccionable coleccion)
		{
			string[] nombres = { "Juan", "Ana", "Luis", "Maria", "Carlos", "Laura", "Miguel", "Elena", "Andrés","Leo","Uriel","Luz","Roberto","Nicolas","Samu","Belen","Nahuel","Rosana","Damian","Carmelo"};
			ArrayList dni = new ArrayList();
			ArrayList legajo=new ArrayList();
			ArrayList promedio=new ArrayList(){1,4,2,6,8,2,5,7,9,10,5,7,8,9,1,2,4,8,3,7,10};
			
			for (int j=44636800;j<=44636819;j++)
			{
				dni.Add(j);
			}
			for (int m=400;m<=419;m++)
			{
				legajo.Add(m);
			}
			for (int i=0;i<=19;i++)
			{
				Alumno per=new Alumno(nombres[i],(int)dni[i],(int)legajo[i],(int)promedio[i]);
				coleccion.agregar(per);
			}
		}
		//Ejercicio 6
		public static void informar(Icoleccionable coleccion)
		{
			Console.WriteLine(coleccion.cuantos());
			Console.WriteLine(coleccion.minimo());
			Console.WriteLine(coleccion.maximo());
			
			
			
			Console.WriteLine("1_ Desea consultar Persona ");
			Console.WriteLine("2_ Desea consultar Alumno ");
			Console.WriteLine("3_ Desea consultar Numero entero ");
			
			Console.Write("Ingrese una opcion: ");
			int opcion=int.Parse(Console.ReadLine());
			
			if (opcion==1)
			{
				Console.Write("Ingrese el dni a comparar: ");
				int dni=int.Parse(Console.ReadLine());
				Persona per=new Persona("",dni);
				if (coleccion.contiene(per))
				{
					Console.WriteLine("El elemento leido esta en la coleccion");
				}
				else
				{
					Console.WriteLine("El elemento leido no esta en la coleccion");
				}
			}
			if (opcion==2)
			{
				Console.Write("Ingrese el promedio a comparar: ");
				int promedio=int.Parse(Console.ReadLine());
				Alumno alum=new Alumno("",0,0,promedio);
				if (coleccion.contiene(alum))
				{
					Console.WriteLine("El elemento leido esta en la coleccion");
				}
				else
				{
					Console.WriteLine("El elemento leido no esta en la coleccion");
				}
			}
			if (opcion==3)
			{
				Console.Write("Ingrese el numero entero a comparar: ");
				int num=int.Parse(Console.ReadLine());
				Numero nume=new Numero(num);
				if (coleccion.contiene(nume))
				{
					Console.WriteLine("El elemento leido esta en la coleccion");
				}
				else
				{
					Console.WriteLine("El elemento leido no esta en la coleccion");
				}
			}

		}
		public static void Main(string[] args)
		{
			
			Pila pila= new Pila();
			Cola cola=new Cola();
			
			ColeccionMultiple multiple=new ColeccionMultiple(pila,cola);
			
			llenaAlumnos (pila);
			llenaAlumnos (cola);
			informar(multiple);
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}