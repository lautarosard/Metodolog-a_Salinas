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

namespace Ejercicio14
{
	/// <summary>
	/// Description of CompararDni.
	/// </summary>
	public class CompararDni:IEstrategiaComparacion
	{
		public CompararDni()
		{
		}
		public bool sosIgual(Persona Alu1, Persona Alu2)
		{
			//Comparar por nombres
			return Alu1.Dni ==  Alu2.Dni;
		}
		public bool sosMayor(Persona Alu1, Persona Alu2)
		{
			//Comparar por nombres
			return Alu1.Dni < Alu2.Dni;
		}
		public bool sosMenor(Persona Alu1, Persona Alu2)
		{
			//Comparar por nombres
			return Alu1.Dni > Alu2.Dni;
		}
	}
}
