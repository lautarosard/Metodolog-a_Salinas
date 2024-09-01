using System;

namespace Pract1
{

	//Ejercicio 3
	public interface Icoleccionable
	{
		int cuantos();
		Icomparable minimo();
		Icomparable maximo();
		void agregar(Icomparable m);
		bool contiene(Icomparable m);
	}
}
