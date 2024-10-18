/*
 * User: lauta
 * Date: 7/9/2024
 */
using System;

namespace Ejercicio8
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
					fabrica = new FabricasDeAlumnos();
					break;
				case 2:
					fabrica = new FabricaDeProfesores();
					break;
				case 3:
					fabrica = new FabricaDeAlumnosMuyEstudiosos();
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
					fabrica = new FabricaDeAlumnosMuyEstudiosos();
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
