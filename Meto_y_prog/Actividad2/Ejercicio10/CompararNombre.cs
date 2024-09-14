/*
 * Created by SharpDevelop.
 * User: lauta
 * Date: 5/9/2024
 * Time: 16:02
 * 
 * To change Alu1 template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Ejercicio10
{
	/// <summary>
	/// Description of CompararNombre.
	/// </summary>
	public class CompararNombre:IEstrategiaComparacion
	{
		public CompararNombre()
		{
		}
		
		public bool sosIgual(Alumno Alu1, Alumno Alu2)
		{
			//Comparar por nombres
			return Alu1.Nombre.Length == Alu2.Nombre.Length;
		}
		public bool sosMayor(Alumno Alu1, Alumno Alu2)
		{
			//Comparar por nombres
			return Alu1.Nombre.Length < Alu2.Nombre.Length;
		}
		public bool sosMenor(Alumno Alu1, Alumno Alu2)
		{
			//Comparar por nombres
			return Alu1.Nombre.Length > Alu2.Nombre.Length;
		}
	}
}
