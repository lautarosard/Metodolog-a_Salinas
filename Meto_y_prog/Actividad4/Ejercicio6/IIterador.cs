/*
 * User: lauta
 * Date: 11/9/2024
 */
using System;

namespace Ejercicio6
{
	/// <summary>
	/// Description of Iterador.
	/// </summary>
	public interface IIterador
	{
		void primero();
		void siguiente();
		bool fin();
		IComparable actual();
	}
}
