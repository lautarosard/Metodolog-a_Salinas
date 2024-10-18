/*
 * Created by SharpDevelop.
 * User: lauta
 * Date: 5/9/2024
 * Time: 16:00
 * 
 * To change Alu1 template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Ejercicio8
{
	public interface IEstrategiaComparacion
	{
		bool sosIgual(IAlumno Alu1, IAlumno Alu2);
		bool sosMayor(IAlumno Alu1, IAlumno Alu2);
		bool sosMenor(IAlumno Alu1, IAlumno Alu2);
		
	}
}
