﻿/*
 * Created by SharpDevelop.
 * User: lauta
 * Date: 6/9/2024
 * Time: 12:55
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Ejercicio1
{
	/// <summary>
	/// Description of CompararLegajo.
	/// </summary>
	public class CompararLegajo:IEstrategiaComparacion
	{
		public CompararLegajo()
		{
		}
		public bool sosIgual(Alumno Alu1)
		{
			//Comparar por nombres
			return this.legajo == Alu1.legajo
		}
		public bool sosMayor(Alumno Alu1)
		{
			//Comparar por nombres
			return Alu1.legajo < Alu1.legajo
		}
		public bool sosMenor(Alumno Alu1)
		{
			//Comparar por nombres
			return Alu1.legajo > Alu1.legajo
		}
	}
}
