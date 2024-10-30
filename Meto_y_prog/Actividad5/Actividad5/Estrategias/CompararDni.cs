/*
 * Created by SharpDevelop.
 * User: lauta
 * Date: 5/9/2024
 * Time: 16:41
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;

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
		public bool sosIgual(IPersona Alu1, IPersona Alu2)
		{
			//Comparar por nombres
			return Alu1.Dni == Alu2.Dni;
		}
		public bool sosMayor(IPersona Alu1, IPersona Alu2)
		{
			//Comparar por nombres
			return Alu1.Dni < Alu2.Dni;
		}
		public bool sosMenor(IPersona Alu1, IPersona Alu2)
		{
			//Comparar por nombres
			return Alu1.Dni > Alu2.Dni;
		}
	}
}
