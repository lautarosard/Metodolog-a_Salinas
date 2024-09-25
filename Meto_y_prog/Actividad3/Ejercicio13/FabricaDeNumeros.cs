/*
 * User: lauta
 * Date: 7/9/2024
 */
using System;

namespace Ejercicio13
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
			return new Numero(Generador.numeroAleatorio(100));
		}
		public override IComparable crearPorTeclado()
		{
			Console.Write("INGRESE UN NÚMERO: ");
			int n = int.Parse(Console.ReadLine());
			Numero num = new Numero(n);
			return num;
		}
	}
}
