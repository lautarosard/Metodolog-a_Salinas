/*
 * Created by SharpDevelop.
 * User: lauta
 * Date: 6/9/2024
 * Time: 12:10
 * 
 * To change (Alumno)Alu1 template use Tools | Options | Coding | Edit Standard Headers.
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
		public bool sosIgual( IPersona Alu1, IPersona Alu2)
		{
			Alumno alu1 = (Alumno)Alu1;
			Alumno alu2 = (Alumno)Alu2;
			//Comparar por nombres
			return alu1.Promedio == alu2.Promedio;
		}
		public bool sosMayor( IPersona Alu1, IPersona Alu2)
		{
			Alumno alu1 = (Alumno)Alu1;
			Alumno alu2 = (Alumno)Alu2;
		    //Comparar por nombres
			return alu1.Promedio < alu2.Promedio;
		}
		public bool sosMenor( IPersona Alu1, IPersona Alu2)
		{
			Alumno alu1 = (Alumno)Alu1;
			Alumno alu2 = (Alumno)Alu2;
			//Comparar por nombres
			return alu1.Promedio > alu2.Promedio;
		}
	}
}
