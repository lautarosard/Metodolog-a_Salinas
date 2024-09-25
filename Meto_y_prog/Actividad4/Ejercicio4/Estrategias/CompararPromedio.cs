/*
 * Created by SharpDevelop.
 * User: lauta
 * Date: 6/9/2024
 * Time: 12:10
 * 
 * To change Alu1 template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Ejercicio4
{
	/// <summary>
	/// Description of CompararPromedio.
	/// </summary>
	public class CompararPromedio:IEstrategiaComparacion
	{
		public CompararPromedio()
		{
		}
		public bool sosIgual(Alumno Alu1,  Alumno Alu2)
		{
			//Comparar por nombres
			return Alu1.promedio == Alu2.promedio;
		}
		public bool sosMayor(Alumno Alu1,  Alumno Alu2)
		{
		    //Comparar por nombres
			return Alu1.promedio < Alu2.promedio;
		}
		public bool sosMenor(Alumno Alu1,  Alumno Alu2)
		{
			//Comparar por nombres
			return Alu1.promedio > Alu2.promedio;
		}
	}
}
