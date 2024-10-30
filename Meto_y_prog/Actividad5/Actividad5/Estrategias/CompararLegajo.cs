/*
 * Created by SharpDevelop.
 * User: lauta
 * Date: 6/9/2024
 * Time: 12:55
 * 
 * To change Alu1 template use Tools | Options | Coding | Edit Standard Headers.
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
		public bool sosIgual(IPersona Alu1,  IPersona Alu2)
		{
			//Comparar por nombres
			return (Alumno)Alu1.Legajo == (Alumno)Alu2.Legajo;
		}
		public bool sosMayor(IPersona Alu1,  IPersona Alu2)
		{
			//Comparar por nombres
			return (Alumno)Alu1.Legajo < (Alumno)Alu2.Legajo;
		}
		public bool sosMenor(IPersona Alu1,  IPersona Alu2)
		{
			//Comparar por nombres
			return (Alumno)Alu1.Legajo > (Alumno)Alu2.Legajo;
		}
	}
}
