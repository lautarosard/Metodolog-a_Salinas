/*
 * User: lauta
 * Date: 11/9/2024
 */
using System;

namespace Ejercicio10
{
	/// <summary>
	/// Description of Iterador.
	/// </summary>
	public interface IIterador
	{
		void primero();
		void siguiente();
		bool fin();
		AlumnoAdapter actual();
	}
}
