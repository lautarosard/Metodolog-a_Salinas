/*
 * Created by SharpDevelop.
 * User: lauta
 * Date: 6/9/2024
 * Time: 12:10
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Ejercicio1
{
	/// <summary>
	/// Description of CompararPromedio.
	/// </summary>
	public class CompararPromedio:IEstrategiaComparacion
	{
		public CompararPromedio()
		{
		}
		public bool sosIgual(Alumno Alu1)
		{
			//Comparar por nombres
			return this.promedio == Alu1.promedio
		}
		public bool sosMayor(Alumno Alu1)
		{
			//Comparar por nombres
			return Alu1.promedio < Alu1.promedio
		}
		public bool sosMenor(Alumno Alu1)
		{
			//Comparar por nombres
			return Alu1.promedio > Alu1.promedio
		}
	}
}
