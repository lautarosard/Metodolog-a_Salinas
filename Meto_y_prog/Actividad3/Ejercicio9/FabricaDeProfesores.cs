/*
 * User: lauta
 * Date: 19/9/2024
 */
using System;

namespace Ejercicio9
{
	/// <summary>
	/// Description of FabricaDeProfesores.
	/// </summary>
	public class FabricaDeProfesores:FabricaDeComparables
	{
		public FabricaDeProfesores()
		{
		}
		
		public override IComparable crearAleatorio()
		{
			string Nombre;
			int Dni;
			int antiguedad;
			Random Dniran = new Random();
			GeneradorDeDatosAleateorio ram = new GeneradorDeDatosAleateorio();
			Nombre = ram.stringAleatorio(ram.numeroAleatorio(8));
			Dni= Dniran.Next(44500900,48800900);
			antiguedad=ram.numeroAleatorio(20);
			Profesor profe = new Profesor(Nombre,Dni,antiguedad);
			return profe;
		}
		
		public override IComparable crearPorTeclado()
		{
			string Nombre;
			int Dni;
			int antiguedad;
			Console.Write("Ingrese su nombre: ");
			Nombre = Console.ReadLine();
			Console.WriteLine();
			Console.Write("Ingrese su DNI: ");
			Dni= int.Parse(Console.ReadLine());
			Console.WriteLine();
			Console.Write("Ingrese su antiguedad: ");
			antiguedad=int.Parse(Console.ReadLine());
			Console.WriteLine();
			Profesor profe= new Profesor(Nombre,Dni,antiguedad);
			return profe;
		}
	}
}
