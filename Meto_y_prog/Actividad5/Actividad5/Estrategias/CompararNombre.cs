/*
 * Created by SharpDevelop.
 * User: lauta
 * Date: 5/9/2024
 * Time: 16:02
 * 
 * To change Alu1 template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Ejercicio1
{
	/// <summary>
	/// Description of CompararNombre.
	/// </summary>
	public class CompararNombre:IEstrategiaComparacion
	{
		public CompararNombre()
		{
		}
		
		public bool sosIgual(IPersona Alu1, IPersona Alu2)
		{
			//Comparar por nombres
			return Alu1.Nombre.Length == Alu2.Nombre.Length;
		}
		public bool sosMayor(IPersona Alu1, IPersona Alu2)
		{
			//Comparar por nombres
			return Alu1.Nombre.Length < Alu2.Nombre.Length;
		}
		public bool sosMenor(IPersona Alu1, IPersona Alu2)
		{
			//Comparar por nombres
			return Alu1.Nombre.Length > Alu2.Nombre.Length;
		}
	}
}
