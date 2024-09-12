/*
 * Created by SharpDevelop.
 * User: lauta
 * Date: 5/9/2024
 * Time: 16:41
 * 
 * To change Alu1 template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Ejercicio2
{
	/// <summary>
	/// Description of CompararDni.
	/// </summary>
	public class CompararDni:IEstrategiaComparacion
	{
		public CompararDni()
		{
		}
		public bool sosIgual(Alumno Alu1,  Alumno Alu2)
		{
			//Comparar por nombres
			return Alu1.Dni == Alu1.Dni;
		}
		public bool sosMayor(Alumno Alu1,  Alumno Alu2)
		{
			//Comparar por nombres
			return Alu1.Dni < Alu1.Dni;
		}
		public bool sosMenor(Alumno Alu1,  Alumno Alu2)
		{
			//Comparar por nombres
			return Alu1.Dni > Alu1.Dni;
		}
	}
}
