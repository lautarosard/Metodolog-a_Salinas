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
