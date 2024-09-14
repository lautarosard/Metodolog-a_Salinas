/*
 * Created by SharpDevelop.
 * User: lauta
 * Date: 5/9/2024
 * Time: 16:00
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Ejercicio8
{
	public interface IEstrategiaComparacion
	{
		bool sosIgual(Alumno Alu1,Alumno Alu2);
		bool sosMayor(Alumno Alu1,Alumno Alu2);
		bool sosMenor(Alumno Alu1,Alumno Alu2);
		
	}
}
