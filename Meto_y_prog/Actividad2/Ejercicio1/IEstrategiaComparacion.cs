/*
 * Created by SharpDevelop.
 * User: lauta
 * Date: 5/9/2024
 * Time: 16:00
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Ejercicio1
{
	public interface IEstrategiaComparacion
	{
		bool sosIgual(Alumno Alu1);
		bool sosMayor(Alumno Alu1);
		bool sosMenor(Alumno Alu1);
		
	}
}
