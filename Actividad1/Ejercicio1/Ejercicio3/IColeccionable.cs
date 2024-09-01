/*
 * Created by SharpDevelop.
 * User: lauta
 * Date: 30/08/2024
 * Time: 03:48 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Ejercicio3
{
	public interface IColeccionable
	{
		int Cuantos();
		int Minimo();
		List<IComparable<t>> Agregar(IComparable);
		bool Contiene(IComparable);
	}
}
