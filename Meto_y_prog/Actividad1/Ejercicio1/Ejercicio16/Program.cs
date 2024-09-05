using System;

namespace Ejercicio16
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
				int n1 = Ram.Next(1);
				int n2 = Ram.Next(1);
				double Promedio = (n1 + n2)/2
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
				coleccion.Agregar(Pers);
			}
		}
	}
}