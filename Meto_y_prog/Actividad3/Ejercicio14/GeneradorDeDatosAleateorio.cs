/*
 * User: lauta
 * Date: 7/9/2024
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio14
{
	/// <summary>
	/// Description of GeneradorDeDatosAleateorio.
	/// </summary>
	public class GeneradorDeDatosAleateorio
	{
		private static Random Ram= new Random();
		public GeneradorDeDatosAleateorio()
		{
		}
		public int numeroAleatorio(int max)
		{
			return Ram.Next(0,max+1);
			
		}
		
		public string stringAleatorio(int cant)
		{
			Console.WriteLine("Creando string");
			string[] abc= new String[]{"A","B","C","D","E","F","G","H","I","J","K","L","M","N","Ñ","O","P","Q","R","S","T","U","V","W","X","Y","Z"};
			StringBuilder crearNomb=new StringBuilder();
			int ind1;
			string nombre;
			for(int i=0;i < cant;i++)
			{
				Console.WriteLine("cantidad de caracteres: " + cant);
				ind1 = Ram.Next(abc.Length);
				Console.WriteLine("caracter: " + abc[ind1]);
				crearNomb.Append(abc[ind1]);
			}
			nombre=crearNomb.ToString();
			Console.WriteLine("Nombre creado: " + nombre);
			return nombre;
		}
	}
}
