/*
 * Created by SharpDevelop.
 * User: lauta
 * Date: 5/9/2024
 * Time: 16:00
 * 
 * To change Alu1 template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Ejercicio1
{
	public interface IEstrategiaComparacion
	{
		bool sosIgual(IPersona Alu1, IPersona Alu2);
		bool sosMayor(IPersona Alu1, IPersona Alu2);
		bool sosMenor(IPersona Alu1, IPersona Alu2);
		
	}
}
