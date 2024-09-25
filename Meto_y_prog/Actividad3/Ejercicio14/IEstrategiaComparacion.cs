/*
 * Created by SharpDevelop.
 * User: lauta
 * Date: 5/9/2024
 * Time: 16:00
 * 
 * To change Alu1 template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Ejercicio14
{
	public interface IEstrategiaComparacion
	{
		bool sosIgual(Persona Alu1, Persona Alu2);
		bool sosMayor(Persona Alu1, Persona Alu2);
		bool sosMenor(Persona Alu1, Persona Alu2);
		
	}
}
