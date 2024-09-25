/*
 * User: lauta
 * Date: 7/9/2024
 */
using System;

namespace Ejercicio14
{
	/// <summary>
	/// Description of IObsevado.
	/// </summary>
	public interface IObservado
	{
		void agregarObsevador(IObservador O);
		void quitarObservador(IObservador O);
		void notificar();
	}
}
