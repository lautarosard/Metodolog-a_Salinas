/*
 * User: lauta
 * Date: 7/9/2024
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio4
{
	/// <summary>
	/// Description of GeneradorDeDatosAleateorio.
	/// </summary>
	public class GeneradorDeDatosAleateorio
	{
		public GeneradorDeDatosAleateorio()
		{
		}
		public int numeroAleatorio(int max)
		{
			Random Ram= new Random();
			int num = Ram.Next(max)
			return num
			
		}
		
		public string stringAleatorio(int cant)
		{
			string[] abc= new String[]{"A","B","C","D","E","F","G","H","I","J","K","L","M","N","Ñ","O","P","Q","R","S","T","U","V","W","X","Y","Z"};
			Random Ram= new Random();
			StringBuilder crearNomb=new StringBuilder();
			int ind1;
			string nombre;
			for(int i=0;0<=cant;i++)
			{
				ind1 = Ram.Next(abc.Length);
				crearNomb.Append(abc[ind1])
			}
			nombre=crearNomb.ToString();
		}
	}
}
