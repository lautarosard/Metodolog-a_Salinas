/*
 * Created by SharpDevelop.
 * User: lauta
 * Date: 6/9/2024
 * Time: 12:55
 * 
 * To change Alu1 template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Ejercicio8
{
	/// <summary>
	/// Description of CompararLegajo.
	/// </summary>
	public class CompararLegajo:IEstrategiaComparacion
	{
		public CompararLegajo()
		{
		}
		public bool sosIgual(IAlumno Alu1, IAlumno Alu2)
		{
			//Comparar por nombres
			return Alu1.Legajo == Alu2.Legajo;
		}
		public bool sosMayor(IAlumno Alu1, IAlumno Alu2)
		{
			//Comparar por nombres
			return Alu1.Legajo < Alu2.Legajo;
		}
		public bool sosMenor(IAlumno Alu1, IAlumno Alu2)
		{
			//Comparar por nombres
			return Alu1.Legajo > Alu2.Legajo;
		}
	}
}
