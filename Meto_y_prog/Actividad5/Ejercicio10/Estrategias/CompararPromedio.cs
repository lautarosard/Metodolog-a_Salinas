/*
 * Created by SharpDevelop.
 * User: lauta
 * Date: 6/9/2024
 * Time: 12:10
 * 
 * To change (Alumno)Alu1 template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Ejercicio10
{
	/// <summary>
	/// Description of CompararPromedio.
	/// </summary>
	public class CompararPromedio:IEstrategiaComparacion
	{
		public CompararPromedio()
		{
		}
		public bool sosIgual( IAlumno Alu1, IAlumno Alu2)
		{
			//Comparar por nombres
			return Alu1.Promedio == Alu2.Promedio;
		}
		public bool sosMayor( IAlumno Alu1, IAlumno Alu2)
		{
		    //Comparar por nombres
			return Alu1.Promedio < Alu2.Promedio;
		}
		public bool sosMenor( IAlumno Alu1, IAlumno Alu2)
		{
			//Comparar por nombres
			return Alu1.Promedio > Alu2.Promedio;
		}
	}
}
