/*
 * Created by SharpDevelop.
 * User: lauta
 * Date: 5/9/2024
 * Time: 16:02
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Ejercicio1
{
	/// <summary>
	/// Description of CompararNombre.
	/// </summary>
	public class CompararNombre:IEstrategiaComparacion
	{
		public CompararNombre()
		{
		}
		
		public bool sosIgual(Alumno Alu2)
		{
			//Comparar por nombres
			return this.Nombre.Length == Alu2.Nombre.Length;
		}
		public bool sosMayor(Alumno Alu2)
		{
			//Comparar por nombres
			return this.Nombre.Length < Alu2.Nombre.Length;
		}
		public bool sosMenor(Alumno Alu2)
		{
			//Comparar por nombres
			return this.Nombre.Length > Alu2.Nombre.Length;
		}
	}
}
