/*
 * Created by SharpDevelop.
 * User: lauta
 * Date: 6/9/2024
 * Time: 12:10
 * 
 * To change (Alumno)Alu1 template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Ejercicio1
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
			//Comparar por nombres
			return (Alumno)Alu1.Promedio == (Alumno)Alu2.Promedio;
		}
		public bool sosMayor( IPersona Alu1, IPersona Alu2)
		{
		    //Comparar por nombres
			return (Alumno)Alu1.Promedio < (Alumno)Alu2.Promedio;
		}
		public bool sosMenor( IPersona Alu1, IPersona Alu2)
		{
			//Comparar por nombres
			return (Alumno)Alu1.Promedio > (Alumno)Alu2.Promedio;
		}
	}
}
