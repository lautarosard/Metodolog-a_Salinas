using System;
using System.Collections.Generic;

namespace Ejercicio10
{
	public interface IColeccionable
	{
		int Cuantos();
		AlumnoAdapter Minimo();
		AlumnoAdapter Maximo();
		void Agregar(AlumnoAdapter c);
		bool Contiene(AlumnoAdapter c);
	}
}
