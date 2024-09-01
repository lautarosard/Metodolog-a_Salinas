/*
 * Created by SharpDevelop.
 * User: lauta
 * Date: 30/08/2024
 * Time: 03:48 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;

namespace Ejercicio8
{
	public interface IColeccionable
	{
		int Cuantos();
		IComparable Minimo();
		IComparable Maximo();
		void Agregar(IComparable c);
		bool Contiene(IComparable c);
	}
}
