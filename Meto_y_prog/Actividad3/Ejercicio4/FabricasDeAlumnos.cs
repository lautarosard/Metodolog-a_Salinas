/*
 * User: lauta
 * Date: 14/9/2024
 */
using System;

namespace Ejercicio4
{
	/// <summary>
	/// Description of FabricasDeAlumnos.
	/// </summary>
	public class FabricasDeAlumnos
	{
		public FabricasDeAlumnos()
		{
		}
	
		public override IComparable crearAleatorio()
		{
			string Nombre;
			int Dni;
			int Legajo;
			double Promedio;
			Random Dniran;
			GeneradorDeDatosAleateorio ram;
			Nombre = ram.stringAleatorio(ram.numeroAleatorio(8));
			Dni= Dniran.Next(44500900,48800900);
			Legajo=ram.numeroAleatorio(4000);
			Promedio = (ram.numeroAleatorio(10)+ram.numeroAleatorio(10))/2;
			Alumno alum = new Alumno(Nombre,Dni,Legajo,Promedio);
		}
		public override IComparable crearPorTeclado()
		{
			
			string Nombre;
			int Dni;
			int Legajo;
			double Promedio;
			Console.Write("Ingrese su nombre: ");
			Nombre = Console.ReadKey();
			Console.WriteLine();
			Console.Write("Ingrese su DNI: ");
			Dni= Console.ReadKey();
			Console.WriteLine();
			Console.Write("Ingrese su Legajo: ");
			Legajo=Console.ReadKey();
			Console.WriteLine();
			Console.Write("Ingrese su Promedio: ");
			Promedio = Console.ReadKey();
			Alumno alum = new Alumno(Nombre,Dni,Legajo,Promedio);
		}
	}
}
