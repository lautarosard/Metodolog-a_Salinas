/*
 * Created by SharpDevelop.
 * User: lauta
 * Date: 5/9/2024
 * Time: 16:41
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Ejercicio1
{
	/// <summary>
	/// Description of CompararDni.
	/// </summary>
	public class CompararDni:IEstrategiaComparacion
	{
		public CompararDni()
		{
		}
		public bool sosIgual(Alumno Alu1)
		{
			//Comparar por nombres
			return this.Dni == Alu1.Dni
		}
		public bool sosMayor(Alumno Alu1)
		{
			//Comparar por nombres
			return Alu1.Dni < Alu1.Dni
		}
		public bool sosMenor(Alumno Alu1)
		{
			//Comparar por nombres
			return Alu1.Nombre > Alu1.Dni
		}
	}
}
