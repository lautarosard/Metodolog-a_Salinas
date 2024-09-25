/*
 * User: lauta
 * Date: 25/9/2024
 */
using System;

namespace Ejercicio4
{
	/// <summary>
	/// Description of IPersona.
	/// </summary>
	public interface IPersona
	{
		string nombre;
		int dni;
		bool SosMenor(IComparable C);
		bool SosMayor(IComparable C);
		bool SosIgual(IComparable C)
	}
}
