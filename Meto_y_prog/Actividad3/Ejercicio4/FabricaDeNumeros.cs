/*
 * User: lauta
 * Date: 7/9/2024
 */
using System;

namespace Ejercicio4
{
	/// <summary>
	/// Description of FabricaDeNumeros.
	/// </summary>
	public class FabricaDeNumeros:FabricaDeComparables
	{
		
		public FabricaDeNumeros()
		{
		}
		public override IComparable crearAleatorio()
		{
			return new Numero(Generador.numeroAleatorio(100))
		}
		public override IComparable crearPorTeclado()
		{
			Console.Write("INGRESE UN NÚMERO: ");
			int n = Console.ReadKey();
			Numero num = new Numero(n);
		}
	}
}
