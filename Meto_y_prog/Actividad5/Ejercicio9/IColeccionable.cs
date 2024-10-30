using System;
using System.Collections.Generic;

namespace Ejercicio9
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
