﻿/*
 * User: lauta
 * Date: 25/9/2024
 */
using System;

namespace Ejercicio1
{
	/// <summary>
	/// Description of FabricaDeAlumnosMuyEstudiosos.
	/// </summary>
	public class FabricaDeAlumnosMuyEstudiosos:FabricaDeComparables
	{
		public FabricaDeAlumnosMuyEstudiosos()
		{
		}
		public override IComparable crearAleatorio()
		{
			string Nombre;
			int Dni;
			int Legajo;
			double Promedio;
			Random Dniran = new Random();
			GeneradorDeDatosAleateorio ram = new GeneradorDeDatosAleateorio();
			Nombre = ram.stringAleatorio(ram.numeroAleatorio(8));
			Dni= Dniran.Next(44500900,48800900);
			Legajo=ram.numeroAleatorio(4000);
			Promedio = (ram.numeroAleatorio(10)+ram.numeroAleatorio(10))/2;
			return new AlumnoMuyEstudioso(Nombre,Dni,Legajo,Promedio);
		}
		public override IComparable crearPorTeclado()
		{
			
			string Nombre;
			int Dni;
			int Legajo;
			double Promedio;
			Console.Write("Ingrese su nombre: ");
			Nombre = Console.ReadLine();
			Console.WriteLine();
			Console.Write("Ingrese su DNI: ");
			Dni= int.Parse(Console.ReadLine());
			Console.WriteLine();
			Console.Write("Ingrese su Legajo: ");
			Legajo=int.Parse(Console.ReadLine());
			Console.WriteLine();
			Console.Write("Ingrese su Promedio: ");
			Promedio = int.Parse(Console.ReadLine());
			return new AlumnoMuyEstudioso(Nombre,Dni,Legajo,Promedio);
		}
	}
}