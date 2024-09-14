/*
 * Created by SharpDevelop.
 * User: lauta
 * Date: 6/9/2024
 * Time: 12:55
 * 
 * To change Alu1 template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Ejercicio10
{
	/// <summary>
	/// Description of CompararLegajo.
	/// </summary>
	public class CompararLegajo:IEstrategiaComparacion
	{
		public CompararLegajo()
		{
		}
		public bool sosIgual(Alumno Alu1,  Alumno Alu2)
		{
			//Comparar por nombres
			return Alu1.legajo == Alu2.legajo;
		}
		public bool sosMayor(Alumno Alu1,  Alumno Alu2)
		{
			//Comparar por nombres
			return Alu1.legajo < Alu2.legajo;
		}
		public bool sosMenor(Alumno Alu1,  Alumno Alu2)
		{
			//Comparar por nombres
			return Alu1.legajo > Alu2.legajo;
		}
	}
}
